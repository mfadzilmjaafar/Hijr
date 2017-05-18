using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hijr.Controllers
{
    public class PesertaController : Controller
    {
        // GET: Peserta
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetPeserta(string ic)
        {
            System.Threading.Thread.Sleep(1000);
            Models.PesertaHaji.Peserta pesertamodel = new Models.PesertaHaji.Peserta();
            using(HijrDataLayer.HIJREntities ent = new HijrDataLayer.HIJREntities())
            {
                var peserta = from pesertaent in ent.CIFs
                              where pesertaent.NoIC == ic
                              select pesertaent;

                foreach(var p in peserta)
                {
                    pesertamodel.Nama = p.Nama;
                    pesertamodel.KadPengenalan = p.NoIC;
                    pesertamodel.Alamat1 = p.Alamat1;
                    pesertamodel.Alamat2 = p.Alamat2;
                    pesertamodel.Alamat3 = p.Alamat3;
                    pesertamodel.Bandar = p.Bandar;
                    pesertamodel.Poskod = p.Poskod;
                    pesertamodel.NoTel = p.NoTel;
                    pesertamodel.Negeri = p.RefNegeri.Negeri;
                    pesertamodel.NoKT = p.Penempatan.NoKT;
                    pesertamodel.NoAkaun = p.Penempatan.NoAkaun;
                    pesertamodel.NoKumpulan = p.Penempatan.NoKumpulan;

                    pesertamodel.KursusPeserta.Lokasi = p.Penempatan.RefKursusPerdana.Lokasi;
                    pesertamodel.KursusPeserta.Tarikh = p.Penempatan.RefKursusPerdana.Tarikh.Substring(0,2)+"/"+
                        p.Penempatan.RefKursusPerdana.Tarikh.Substring(2, 2)+"/"+ p.Penempatan.RefKursusPerdana.Tarikh.Substring(4);
                    pesertamodel.KursusPeserta.Negeri = p.Penempatan.RefKursusPerdana.RefNegeri.Negeri;

                    
                    
                }

                
            }

            //return Json(pesertamodel,JsonRequestBehavior.AllowGet);
            return Json(pesertamodel);
        }

        [HttpPost]
        public JsonResult PairCard(string ic, string tagid)
        {
            System.Threading.Thread.Sleep(3000);
            CardPairResult cpr = new CardPairResult();
            try
            {
                using (HijrDataLayer.HIJREntities ent = new HijrDataLayer.HIJREntities())
                {
                    //check exist or not
                    var pesertacard = from a in ent.CardStocks
                                      where a.custIDNo == ic
                                      select a;


                    //which means tak ada lagi
                    if (pesertacard.Count() == 0)
                    {
                        HijrDataLayer.CardStock cardstock = new HijrDataLayer.CardStock();
                        cardstock.reg_date = DateTime.Now.ToShortDateString().Replace("/", "");
                        cardstock.reg_time = "";
                        cardstock.serial_no = tagid;
                        cardstock.status = "";
                        cardstock.reg_id = tagid;
                        cardstock.first_sn = tagid;
                        cardstock.last_sn = tagid;
                        cardstock.remarks = "Test yo";
                        cardstock.custdist_date = DateTime.Now.ToShortDateString().Replace("/", "");
                        cardstock.custdist_id = ic;
                        cardstock.damage_date = "";
                        cardstock.damage_time = "";
                        cardstock.damage_id = "";
                        cardstock.custIDNo = ic;

                        ent.CardStocks.Add(cardstock);
                        ent.SaveChanges();
                        cpr.Success = true;
                    }
                    else
                    {
                        cpr.Message = "Card already paired.";
                        cpr.Success = false;
                    }
                }
            }
            catch(Exception e)
            {
                cpr.Message = e.Message;
                cpr.Success = false;
            }
            return Json(cpr);
        }

        [HttpPost]
        public JsonResult UpdatePengesahanTawaran(string ic)
        {
            CardPairResult cpr = new CardPairResult();
            try
            {
                using (HijrDataLayer.HIJREntities ent = new HijrDataLayer.HIJREntities())
                {
                    var gerakanpeserta = from a in ent.Pergerakans
                                         where a.NoIC == ic
                                         select a;

                    //which means the peserta record already exist in db
                    if (gerakanpeserta.Count() != 0)
                    {

                    }
                    else//record does not exist
                    {
                        //create new record
                        HijrDataLayer.Pergerakan g = new HijrDataLayer.Pergerakan();
                        g.NoIC = ic;
                        g.Sah = "1";

                        ent.Pergerakans.Add(g);
                        ent.SaveChanges();

                    }

                    cpr.Success = true;
                }
            }
            catch (Exception e)
            {
                cpr.Message = e.Message;
                cpr.Success = false;

            }

            return Json(cpr);
        }

        [HttpPost]
        public JsonResult UpdateKursus(string ic)
        {
            System.Threading.Thread.Sleep(1000);
            CardPairResult cpr = new CardPairResult();
            try
            {
                using (HijrDataLayer.HIJREntities ent = new HijrDataLayer.HIJREntities())
                {
                    var gerakanpeserta = from a in ent.Pergerakans
                                         where a.NoIC == ic
                                         select a;

                    //which means the peserta record already exist in db
                    if (gerakanpeserta.Count() != 0)
                    {
                        foreach(var g in gerakanpeserta)
                        {
                            g.Kursus = "1";
                        }
                    }
                    else//record does not exist
                    {
                        //create new record
                        HijrDataLayer.Pergerakan g = new HijrDataLayer.Pergerakan();
                        g.NoIC = ic;
                        g.Kursus = "1";
                        ent.Pergerakans.Add(g);
                       

                    }
                    ent.SaveChanges();

                    cpr.Success = true;
                }
            }
            catch(Exception e)
            {
                cpr.Message = e.Message;
                cpr.Success = false;
                
            }

            return Json(cpr);
        }

        [HttpPost]
        public JsonResult UpdateKesihatan(string ic)
        {
            CardPairResult cpr = new CardPairResult();
            try
            {
                using (HijrDataLayer.HIJREntities ent = new HijrDataLayer.HIJREntities())
                {
                    var gerakanpeserta = from a in ent.Pergerakans
                                         where a.NoIC == ic
                                         select a;

                    //which means the peserta record already exist in db
                    if (gerakanpeserta.Count() != 0)
                    {

                    }
                    else//record does not exist
                    {
                        //create new record
                        HijrDataLayer.Pergerakan g = new HijrDataLayer.Pergerakan();
                        g.NoIC = ic;
                        g.Kesihatan = "1";

                        ent.Pergerakans.Add(g);
                        ent.SaveChanges();

                    }

                    cpr.Success = true;
                }
            }
            catch(Exception ex)
            {

            }
            return Json(cpr);
        }
    }

    public class CardPairResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }
    }
}