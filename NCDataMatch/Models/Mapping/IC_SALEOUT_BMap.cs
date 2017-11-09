using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataMatch.Models.Mapping
{
    public class IC_SALEOUT_BMap : EntityTypeConfiguration<IC_SALEOUT_B>
    {
        public IC_SALEOUT_BMap()
        {
            // Primary Key
            this.HasKey(t => t.CGENERALBID);

            // Properties
            this.Property(t => t.BADVFEEFLAG)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BBARCODECLOSE)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BLENDOUTFLAG)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BONROADFLAG)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BRETURNPROFIT)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BSAFEPRICE)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BSAMPLE)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BSOURCELARGESS)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BTOU8RM)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BWASTAGEFLAG)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CASSCUSTID)
                .HasMaxLength(20);

            this.Property(t => t.CASTUNITID)
                .HasMaxLength(20);

            this.Property(t => t.CBODYTRANSTYPECODE)
                .HasMaxLength(20);

            this.Property(t => t.CBODYWAREHOUSEID)
                .HasMaxLength(20);

            this.Property(t => t.CCORRESPONDBID)
                .HasMaxLength(20);

            this.Property(t => t.CCORRESPONDCODE)
                .HasMaxLength(40);

            this.Property(t => t.CCORRESPONDHID)
                .HasMaxLength(20);

            this.Property(t => t.CCORRESPONDROWNO)
                .HasMaxLength(40);

            this.Property(t => t.CCORRESPONDTRANSTYPE)
                .HasMaxLength(20);

            this.Property(t => t.CCORRESPONDTYPE)
                .HasMaxLength(20);

            this.Property(t => t.CCOSTOBJECT)
                .HasMaxLength(20);

            this.Property(t => t.CCURRENCYID)
                .HasMaxLength(20);

            this.Property(t => t.CCUSTMATERIALID)
                .HasMaxLength(20);

            this.Property(t => t.CDELIVERY_BBID)
                .HasMaxLength(20);

            this.Property(t => t.CFANACEORGOID)
                .HasMaxLength(20);

            this.Property(t => t.CFFILEID)
                .HasMaxLength(20);

            this.Property(t => t.CFIRSTBILLBID)
                .HasMaxLength(20);

            this.Property(t => t.CFIRSTBILLDATE)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.CFIRSTBILLHID)
                .HasMaxLength(20);

            this.Property(t => t.CFIRSTTRANSTYPE)
                .HasMaxLength(20);

            this.Property(t => t.CFIRSTTYPE)
                .HasMaxLength(20);

            this.Property(t => t.CGENERALBID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.CGENERALHID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.CGLOBALCURRENCYID)
                .HasMaxLength(20);

            this.Property(t => t.CGROUPCURRENCYID)
                .HasMaxLength(20);

            this.Property(t => t.CINVOICECUSTID)
                .HasMaxLength(20);

            this.Property(t => t.CIOLIABILITYOID)
                .HasMaxLength(20);

            this.Property(t => t.CIOLIABILITYVID)
                .HasMaxLength(20);

            this.Property(t => t.CLIABILITYOID)
                .HasMaxLength(20);

            this.Property(t => t.CLIABILITYVID)
                .HasMaxLength(20);

            this.Property(t => t.CLOCATIONID)
                .HasMaxLength(20);

            this.Property(t => t.CMATERIALOID)
                .HasMaxLength(20);

            this.Property(t => t.CMATERIALVID)
                .HasMaxLength(20);

            this.Property(t => t.CORIGAREAID)
                .HasMaxLength(20);

            this.Property(t => t.CORIGCOUNTRYID)
                .HasMaxLength(20);

            this.Property(t => t.CORIGCURRENCYID)
                .HasMaxLength(20);

            this.Property(t => t.CORPOID)
                .HasMaxLength(20);

            this.Property(t => t.CORPVID)
                .HasMaxLength(20);

            this.Property(t => t.CPRODLINEID)
                .HasMaxLength(20);

            this.Property(t => t.CPRODUCTORID)
                .HasMaxLength(20);

            this.Property(t => t.CPROJECTID)
                .HasMaxLength(20);

            this.Property(t => t.CQTUNITID)
                .HasMaxLength(20);

            this.Property(t => t.CRECEIEVEID)
                .HasMaxLength(20);

            this.Property(t => t.CRECEIVEAREAID)
                .HasMaxLength(20);

            this.Property(t => t.CRECEIVEPOINTID)
                .HasMaxLength(20);

            this.Property(t => t.CROWNO)
                .HasMaxLength(20);

            this.Property(t => t.CSELASTUNITID)
                .HasMaxLength(20);

            this.Property(t => t.CSIGNWASTBID)
                .HasMaxLength(20);

            this.Property(t => t.CSIGNWASTHID)
                .HasMaxLength(20);

            this.Property(t => t.CSIGNWASTTYPE)
                .HasMaxLength(20);

            this.Property(t => t.CSOURCEBILLBID)
                .HasMaxLength(20);

            this.Property(t => t.CSOURCEBILLDATE)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.CSOURCEBILLHID)
                .HasMaxLength(20);

            this.Property(t => t.CSOURCEMATERIALOID)
                .HasMaxLength(20);

            this.Property(t => t.CSOURCETRANSTYPE)
                .HasMaxLength(20);

            this.Property(t => t.CSOURCETYPE)
                .HasMaxLength(20);

            this.Property(t => t.CSOURCEWASTBID)
                .HasMaxLength(20);

            this.Property(t => t.CSOURCEWASTHID)
                .HasMaxLength(20);

            this.Property(t => t.CSOURCEWASTTRANSTYPE)
                .HasMaxLength(20);

            this.Property(t => t.CSOURCEWASTTYPE)
                .HasMaxLength(20);

            this.Property(t => t.CSRC2BILLBID)
                .HasMaxLength(20);

            this.Property(t => t.CSRC2BILLHID)
                .HasMaxLength(20);

            this.Property(t => t.CSRC2BILLTYPE)
                .HasMaxLength(20);

            this.Property(t => t.CSRC2TRANSTYPE)
                .HasMaxLength(20);

            this.Property(t => t.CSRCMATERIALOID)
                .HasMaxLength(20);

            this.Property(t => t.CSRCMATERIALVID)
                .HasMaxLength(20);

            this.Property(t => t.CSTATEID)
                .HasMaxLength(20);

            this.Property(t => t.CTAXCODEID)
                .HasMaxLength(20);

            this.Property(t => t.CTPLCUSTOMERID)
                .HasMaxLength(20);

            this.Property(t => t.CUNITID)
                .HasMaxLength(20);

            this.Property(t => t.CVENDORID)
                .HasMaxLength(20);

            this.Property(t => t.CVMIVENDERID)
                .HasMaxLength(20);

            this.Property(t => t.DBIZDATE)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.DDELIVERDATE)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.DPRODUCEDATE)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.DVALIDATE)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.FLARGESS)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PK_BATCHCODE)
                .HasMaxLength(20);

            this.Property(t => t.PK_GROUP)
                .HasMaxLength(20);

            this.Property(t => t.PK_MEASWARE)
                .HasMaxLength(20);

            this.Property(t => t.PK_ORG)
                .HasMaxLength(20);

            this.Property(t => t.PK_ORG_V)
                .HasMaxLength(20);

            this.Property(t => t.PK_PACKSORT)
                .HasMaxLength(20);

            this.Property(t => t.PK_RETURNREASON)
                .HasMaxLength(20);

            this.Property(t => t.PK_SERIALCODE)
                .HasMaxLength(20);

            this.Property(t => t.TS)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.VBATCHCODE)
                .HasMaxLength(40);

            this.Property(t => t.VBDEF1)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF10)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF11)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF12)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF13)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF14)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF15)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF16)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF17)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF18)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF19)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF2)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF20)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF3)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF4)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF5)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF6)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF7)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF8)
                .HasMaxLength(101);

            this.Property(t => t.VBDEF9)
                .HasMaxLength(101);

            this.Property(t => t.VBILLBARCODE)
                .HasMaxLength(128);

            this.Property(t => t.VBILLTYPEU8RM)
                .HasMaxLength(20);

            this.Property(t => t.VCHANGERATE)
                .HasMaxLength(60);

            this.Property(t => t.VEXIGENCYBID)
                .HasMaxLength(20);

            this.Property(t => t.VEXIGENCYCODE)
                .HasMaxLength(40);

            this.Property(t => t.VEXIGENCYHID)
                .HasMaxLength(20);

            this.Property(t => t.VEXIGENCYROWNO)
                .HasMaxLength(20);

            this.Property(t => t.VFIRSTBILLCODE)
                .HasMaxLength(40);

            this.Property(t => t.VFIRSTROWNO)
                .HasMaxLength(20);

            this.Property(t => t.VFREE1)
                .HasMaxLength(101);

            this.Property(t => t.VFREE10)
                .HasMaxLength(101);

            this.Property(t => t.VFREE2)
                .HasMaxLength(101);

            this.Property(t => t.VFREE3)
                .HasMaxLength(101);

            this.Property(t => t.VFREE4)
                .HasMaxLength(101);

            this.Property(t => t.VFREE5)
                .HasMaxLength(101);

            this.Property(t => t.VFREE6)
                .HasMaxLength(101);

            this.Property(t => t.VFREE7)
                .HasMaxLength(101);

            this.Property(t => t.VFREE8)
                .HasMaxLength(101);

            this.Property(t => t.VFREE9)
                .HasMaxLength(101);

            this.Property(t => t.VNOTEBODY)
                .HasMaxLength(181);

            this.Property(t => t.VPICKDETAILBID)
                .HasMaxLength(20);

            this.Property(t => t.VPICKDETAILROWNO)
                .HasMaxLength(20);

            this.Property(t => t.VQTUNITRATE)
                .HasMaxLength(60);

            this.Property(t => t.VRECEIVEADDRESS)
                .HasMaxLength(20);

            this.Property(t => t.VSERIALCODE)
                .HasMaxLength(128);

            this.Property(t => t.VSIGNWASTCODE)
                .HasMaxLength(40);

            this.Property(t => t.VSIGNWASTROWNO)
                .HasMaxLength(20);

            this.Property(t => t.VSOURCEBILLCODE)
                .HasMaxLength(40);

            this.Property(t => t.VSOURCEROWNO)
                .HasMaxLength(20);

            this.Property(t => t.VSOURCEWASTCODE)
                .HasMaxLength(40);

            this.Property(t => t.VSOURCEWASTROWNO)
                .HasMaxLength(20);

            this.Property(t => t.VSRC2BILLCODE)
                .HasMaxLength(40);

            this.Property(t => t.VSRC2BILLROWNO)
                .HasMaxLength(20);

            this.Property(t => t.VTRANSFERCODE)
                .HasMaxLength(50);

            this.Property(t => t.VTRANSTYPEU8RM)
                .HasMaxLength(20);

            this.Property(t => t.VVEHICLECODE)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("IC_SALEOUT_B", "NC65");
            this.Property(t => t.BADVFEEFLAG).HasColumnName("BADVFEEFLAG");
            this.Property(t => t.BBARCODECLOSE).HasColumnName("BBARCODECLOSE");
            this.Property(t => t.BLENDOUTFLAG).HasColumnName("BLENDOUTFLAG");
            this.Property(t => t.BONROADFLAG).HasColumnName("BONROADFLAG");
            this.Property(t => t.BRETURNPROFIT).HasColumnName("BRETURNPROFIT");
            this.Property(t => t.BSAFEPRICE).HasColumnName("BSAFEPRICE");
            this.Property(t => t.BSAMPLE).HasColumnName("BSAMPLE");
            this.Property(t => t.BSOURCELARGESS).HasColumnName("BSOURCELARGESS");
            this.Property(t => t.BTOU8RM).HasColumnName("BTOU8RM");
            this.Property(t => t.BWASTAGEFLAG).HasColumnName("BWASTAGEFLAG");
            this.Property(t => t.CASSCUSTID).HasColumnName("CASSCUSTID");
            this.Property(t => t.CASTUNITID).HasColumnName("CASTUNITID");
            this.Property(t => t.CBODYTRANSTYPECODE).HasColumnName("CBODYTRANSTYPECODE");
            this.Property(t => t.CBODYWAREHOUSEID).HasColumnName("CBODYWAREHOUSEID");
            this.Property(t => t.CCORRESPONDBID).HasColumnName("CCORRESPONDBID");
            this.Property(t => t.CCORRESPONDCODE).HasColumnName("CCORRESPONDCODE");
            this.Property(t => t.CCORRESPONDHID).HasColumnName("CCORRESPONDHID");
            this.Property(t => t.CCORRESPONDROWNO).HasColumnName("CCORRESPONDROWNO");
            this.Property(t => t.CCORRESPONDTRANSTYPE).HasColumnName("CCORRESPONDTRANSTYPE");
            this.Property(t => t.CCORRESPONDTYPE).HasColumnName("CCORRESPONDTYPE");
            this.Property(t => t.CCOSTOBJECT).HasColumnName("CCOSTOBJECT");
            this.Property(t => t.CCURRENCYID).HasColumnName("CCURRENCYID");
            this.Property(t => t.CCUSTMATERIALID).HasColumnName("CCUSTMATERIALID");
            this.Property(t => t.CDELIVERY_BBID).HasColumnName("CDELIVERY_BBID");
            this.Property(t => t.CFANACEORGOID).HasColumnName("CFANACEORGOID");
            this.Property(t => t.CFFILEID).HasColumnName("CFFILEID");
            this.Property(t => t.CFIRSTBILLBID).HasColumnName("CFIRSTBILLBID");
            this.Property(t => t.CFIRSTBILLDATE).HasColumnName("CFIRSTBILLDATE");
            this.Property(t => t.CFIRSTBILLHID).HasColumnName("CFIRSTBILLHID");
            this.Property(t => t.CFIRSTTRANSTYPE).HasColumnName("CFIRSTTRANSTYPE");
            this.Property(t => t.CFIRSTTYPE).HasColumnName("CFIRSTTYPE");
            this.Property(t => t.CGENERALBID).HasColumnName("CGENERALBID");
            this.Property(t => t.CGENERALHID).HasColumnName("CGENERALHID");
            this.Property(t => t.CGLOBALCURRENCYID).HasColumnName("CGLOBALCURRENCYID");
            this.Property(t => t.CGROUPCURRENCYID).HasColumnName("CGROUPCURRENCYID");
            this.Property(t => t.CINVOICECUSTID).HasColumnName("CINVOICECUSTID");
            this.Property(t => t.CIOLIABILITYOID).HasColumnName("CIOLIABILITYOID");
            this.Property(t => t.CIOLIABILITYVID).HasColumnName("CIOLIABILITYVID");
            this.Property(t => t.CLIABILITYOID).HasColumnName("CLIABILITYOID");
            this.Property(t => t.CLIABILITYVID).HasColumnName("CLIABILITYVID");
            this.Property(t => t.CLOCATIONID).HasColumnName("CLOCATIONID");
            this.Property(t => t.CMATERIALOID).HasColumnName("CMATERIALOID");
            this.Property(t => t.CMATERIALVID).HasColumnName("CMATERIALVID");
            this.Property(t => t.CORIGAREAID).HasColumnName("CORIGAREAID");
            this.Property(t => t.CORIGCOUNTRYID).HasColumnName("CORIGCOUNTRYID");
            this.Property(t => t.CORIGCURRENCYID).HasColumnName("CORIGCURRENCYID");
            this.Property(t => t.CORPOID).HasColumnName("CORPOID");
            this.Property(t => t.CORPVID).HasColumnName("CORPVID");
            this.Property(t => t.CPRODLINEID).HasColumnName("CPRODLINEID");
            this.Property(t => t.CPRODUCTORID).HasColumnName("CPRODUCTORID");
            this.Property(t => t.CPROJECTID).HasColumnName("CPROJECTID");
            this.Property(t => t.CQTUNITID).HasColumnName("CQTUNITID");
            this.Property(t => t.CRECEIEVEID).HasColumnName("CRECEIEVEID");
            this.Property(t => t.CRECEIVEAREAID).HasColumnName("CRECEIVEAREAID");
            this.Property(t => t.CRECEIVEPOINTID).HasColumnName("CRECEIVEPOINTID");
            this.Property(t => t.CROWNO).HasColumnName("CROWNO");
            this.Property(t => t.CSELASTUNITID).HasColumnName("CSELASTUNITID");
            this.Property(t => t.CSIGNWASTBID).HasColumnName("CSIGNWASTBID");
            this.Property(t => t.CSIGNWASTHID).HasColumnName("CSIGNWASTHID");
            this.Property(t => t.CSIGNWASTTYPE).HasColumnName("CSIGNWASTTYPE");
            this.Property(t => t.CSOURCEBILLBID).HasColumnName("CSOURCEBILLBID");
            this.Property(t => t.CSOURCEBILLDATE).HasColumnName("CSOURCEBILLDATE");
            this.Property(t => t.CSOURCEBILLHID).HasColumnName("CSOURCEBILLHID");
            this.Property(t => t.CSOURCEMATERIALOID).HasColumnName("CSOURCEMATERIALOID");
            this.Property(t => t.CSOURCETRANSTYPE).HasColumnName("CSOURCETRANSTYPE");
            this.Property(t => t.CSOURCETYPE).HasColumnName("CSOURCETYPE");
            this.Property(t => t.CSOURCEWASTBID).HasColumnName("CSOURCEWASTBID");
            this.Property(t => t.CSOURCEWASTHID).HasColumnName("CSOURCEWASTHID");
            this.Property(t => t.CSOURCEWASTTRANSTYPE).HasColumnName("CSOURCEWASTTRANSTYPE");
            this.Property(t => t.CSOURCEWASTTYPE).HasColumnName("CSOURCEWASTTYPE");
            this.Property(t => t.CSRC2BILLBID).HasColumnName("CSRC2BILLBID");
            this.Property(t => t.CSRC2BILLHID).HasColumnName("CSRC2BILLHID");
            this.Property(t => t.CSRC2BILLTYPE).HasColumnName("CSRC2BILLTYPE");
            this.Property(t => t.CSRC2TRANSTYPE).HasColumnName("CSRC2TRANSTYPE");
            this.Property(t => t.CSRCMATERIALOID).HasColumnName("CSRCMATERIALOID");
            this.Property(t => t.CSRCMATERIALVID).HasColumnName("CSRCMATERIALVID");
            this.Property(t => t.CSTATEID).HasColumnName("CSTATEID");
            this.Property(t => t.CTAXCODEID).HasColumnName("CTAXCODEID");
            this.Property(t => t.CTPLCUSTOMERID).HasColumnName("CTPLCUSTOMERID");
            this.Property(t => t.CUNITID).HasColumnName("CUNITID");
            this.Property(t => t.CVENDORID).HasColumnName("CVENDORID");
            this.Property(t => t.CVMIVENDERID).HasColumnName("CVMIVENDERID");
            this.Property(t => t.DBIZDATE).HasColumnName("DBIZDATE");
            this.Property(t => t.DDELIVERDATE).HasColumnName("DDELIVERDATE");
            this.Property(t => t.DPRODUCEDATE).HasColumnName("DPRODUCEDATE");
            this.Property(t => t.DR).HasColumnName("DR");
            this.Property(t => t.DVALIDATE).HasColumnName("DVALIDATE");
            this.Property(t => t.FBILLROWFLAG).HasColumnName("FBILLROWFLAG");
            this.Property(t => t.FLARGESS).HasColumnName("FLARGESS");
            this.Property(t => t.FTAXTYPEFLAG).HasColumnName("FTAXTYPEFLAG");
            this.Property(t => t.IDESATYPE).HasColumnName("IDESATYPE");
            this.Property(t => t.NASSISTNUM).HasColumnName("NASSISTNUM");
            this.Property(t => t.NBARCODENUM).HasColumnName("NBARCODENUM");
            this.Property(t => t.NBDISCOUNTRATE).HasColumnName("NBDISCOUNTRATE");
            this.Property(t => t.NCALTAXMNY).HasColumnName("NCALTAXMNY");
            this.Property(t => t.NCHANGESTDRATE).HasColumnName("NCHANGESTDRATE");
            this.Property(t => t.NCOSTMNY).HasColumnName("NCOSTMNY");
            this.Property(t => t.NCOSTPRICE).HasColumnName("NCOSTPRICE");
            this.Property(t => t.NCOUNTNUM).HasColumnName("NCOUNTNUM");
            this.Property(t => t.NGLOBALEXCHGRATE).HasColumnName("NGLOBALEXCHGRATE");
            this.Property(t => t.NGLOBALMNY).HasColumnName("NGLOBALMNY");
            this.Property(t => t.NGLOBALTAXMNY).HasColumnName("NGLOBALTAXMNY");
            this.Property(t => t.NGROSSNUM).HasColumnName("NGROSSNUM");
            this.Property(t => t.NGROUPEXCHGRATE).HasColumnName("NGROUPEXCHGRATE");
            this.Property(t => t.NGROUPMNY).HasColumnName("NGROUPMNY");
            this.Property(t => t.NGROUPTAXMNY).HasColumnName("NGROUPTAXMNY");
            this.Property(t => t.NITEMDISCOUNTRATE).HasColumnName("NITEMDISCOUNTRATE");
            this.Property(t => t.NMNY).HasColumnName("NMNY");
            this.Property(t => t.NNETPRICE).HasColumnName("NNETPRICE");
            this.Property(t => t.NNUM).HasColumnName("NNUM");
            this.Property(t => t.NORIGMNY).HasColumnName("NORIGMNY");
            this.Property(t => t.NORIGNETPRICE).HasColumnName("NORIGNETPRICE");
            this.Property(t => t.NORIGPRICE).HasColumnName("NORIGPRICE");
            this.Property(t => t.NORIGTAX).HasColumnName("NORIGTAX");
            this.Property(t => t.NORIGTAXMNY).HasColumnName("NORIGTAXMNY");
            this.Property(t => t.NORIGTAXNETPRICE).HasColumnName("NORIGTAXNETPRICE");
            this.Property(t => t.NORIGTAXPRICE).HasColumnName("NORIGTAXPRICE");
            this.Property(t => t.NPIECE).HasColumnName("NPIECE");
            this.Property(t => t.NPLANNEDMNY).HasColumnName("NPLANNEDMNY");
            this.Property(t => t.NPLANNEDPRICE).HasColumnName("NPLANNEDPRICE");
            this.Property(t => t.NPRICE).HasColumnName("NPRICE");
            this.Property(t => t.NQTNETPRICE).HasColumnName("NQTNETPRICE");
            this.Property(t => t.NQTORIGNETPRICE).HasColumnName("NQTORIGNETPRICE");
            this.Property(t => t.NQTORIGPRICE).HasColumnName("NQTORIGPRICE");
            this.Property(t => t.NQTORIGTAXNETPRC).HasColumnName("NQTORIGTAXNETPRC");
            this.Property(t => t.NQTORIGTAXNETPRICE).HasColumnName("NQTORIGTAXNETPRICE");
            this.Property(t => t.NQTORIGTAXPRICE).HasColumnName("NQTORIGTAXPRICE");
            this.Property(t => t.NQTPRICE).HasColumnName("NQTPRICE");
            this.Property(t => t.NQTTAXNETPRICE).HasColumnName("NQTTAXNETPRICE");
            this.Property(t => t.NQTTAXPRICE).HasColumnName("NQTTAXPRICE");
            this.Property(t => t.NQTUNITNUM).HasColumnName("NQTUNITNUM");
            this.Property(t => t.NSHOULDASSISTNUM).HasColumnName("NSHOULDASSISTNUM");
            this.Property(t => t.NSHOULDNUM).HasColumnName("NSHOULDNUM");
            this.Property(t => t.NTARENUM).HasColumnName("NTARENUM");
            this.Property(t => t.NTAX).HasColumnName("NTAX");
            this.Property(t => t.NTAXMNY).HasColumnName("NTAXMNY");
            this.Property(t => t.NTAXNETPRICE).HasColumnName("NTAXNETPRICE");
            this.Property(t => t.NTAXPRICE).HasColumnName("NTAXPRICE");
            this.Property(t => t.NTAXRATE).HasColumnName("NTAXRATE");
            this.Property(t => t.NVOLUME).HasColumnName("NVOLUME");
            this.Property(t => t.NWEIGHT).HasColumnName("NWEIGHT");
            this.Property(t => t.PK_BATCHCODE).HasColumnName("PK_BATCHCODE");
            this.Property(t => t.PK_GROUP).HasColumnName("PK_GROUP");
            this.Property(t => t.PK_MEASWARE).HasColumnName("PK_MEASWARE");
            this.Property(t => t.PK_ORG).HasColumnName("PK_ORG");
            this.Property(t => t.PK_ORG_V).HasColumnName("PK_ORG_V");
            this.Property(t => t.PK_PACKSORT).HasColumnName("PK_PACKSORT");
            this.Property(t => t.PK_RETURNREASON).HasColumnName("PK_RETURNREASON");
            this.Property(t => t.PK_SERIALCODE).HasColumnName("PK_SERIALCODE");
            this.Property(t => t.TS).HasColumnName("TS");
            this.Property(t => t.VBATCHCODE).HasColumnName("VBATCHCODE");
            this.Property(t => t.VBDEF1).HasColumnName("VBDEF1");
            this.Property(t => t.VBDEF10).HasColumnName("VBDEF10");
            this.Property(t => t.VBDEF11).HasColumnName("VBDEF11");
            this.Property(t => t.VBDEF12).HasColumnName("VBDEF12");
            this.Property(t => t.VBDEF13).HasColumnName("VBDEF13");
            this.Property(t => t.VBDEF14).HasColumnName("VBDEF14");
            this.Property(t => t.VBDEF15).HasColumnName("VBDEF15");
            this.Property(t => t.VBDEF16).HasColumnName("VBDEF16");
            this.Property(t => t.VBDEF17).HasColumnName("VBDEF17");
            this.Property(t => t.VBDEF18).HasColumnName("VBDEF18");
            this.Property(t => t.VBDEF19).HasColumnName("VBDEF19");
            this.Property(t => t.VBDEF2).HasColumnName("VBDEF2");
            this.Property(t => t.VBDEF20).HasColumnName("VBDEF20");
            this.Property(t => t.VBDEF3).HasColumnName("VBDEF3");
            this.Property(t => t.VBDEF4).HasColumnName("VBDEF4");
            this.Property(t => t.VBDEF5).HasColumnName("VBDEF5");
            this.Property(t => t.VBDEF6).HasColumnName("VBDEF6");
            this.Property(t => t.VBDEF7).HasColumnName("VBDEF7");
            this.Property(t => t.VBDEF8).HasColumnName("VBDEF8");
            this.Property(t => t.VBDEF9).HasColumnName("VBDEF9");
            this.Property(t => t.VBILLBARCODE).HasColumnName("VBILLBARCODE");
            this.Property(t => t.VBILLTYPEU8RM).HasColumnName("VBILLTYPEU8RM");
            this.Property(t => t.VCHANGERATE).HasColumnName("VCHANGERATE");
            this.Property(t => t.VEXIGENCYBID).HasColumnName("VEXIGENCYBID");
            this.Property(t => t.VEXIGENCYCODE).HasColumnName("VEXIGENCYCODE");
            this.Property(t => t.VEXIGENCYHID).HasColumnName("VEXIGENCYHID");
            this.Property(t => t.VEXIGENCYROWNO).HasColumnName("VEXIGENCYROWNO");
            this.Property(t => t.VFIRSTBILLCODE).HasColumnName("VFIRSTBILLCODE");
            this.Property(t => t.VFIRSTROWNO).HasColumnName("VFIRSTROWNO");
            this.Property(t => t.VFREE1).HasColumnName("VFREE1");
            this.Property(t => t.VFREE10).HasColumnName("VFREE10");
            this.Property(t => t.VFREE2).HasColumnName("VFREE2");
            this.Property(t => t.VFREE3).HasColumnName("VFREE3");
            this.Property(t => t.VFREE4).HasColumnName("VFREE4");
            this.Property(t => t.VFREE5).HasColumnName("VFREE5");
            this.Property(t => t.VFREE6).HasColumnName("VFREE6");
            this.Property(t => t.VFREE7).HasColumnName("VFREE7");
            this.Property(t => t.VFREE8).HasColumnName("VFREE8");
            this.Property(t => t.VFREE9).HasColumnName("VFREE9");
            this.Property(t => t.VNOTEBODY).HasColumnName("VNOTEBODY");
            this.Property(t => t.VPICKDETAILBID).HasColumnName("VPICKDETAILBID");
            this.Property(t => t.VPICKDETAILROWNO).HasColumnName("VPICKDETAILROWNO");
            this.Property(t => t.VQTUNITRATE).HasColumnName("VQTUNITRATE");
            this.Property(t => t.VRECEIVEADDRESS).HasColumnName("VRECEIVEADDRESS");
            this.Property(t => t.VSERIALCODE).HasColumnName("VSERIALCODE");
            this.Property(t => t.VSIGNWASTCODE).HasColumnName("VSIGNWASTCODE");
            this.Property(t => t.VSIGNWASTROWNO).HasColumnName("VSIGNWASTROWNO");
            this.Property(t => t.VSOURCEBILLCODE).HasColumnName("VSOURCEBILLCODE");
            this.Property(t => t.VSOURCEROWNO).HasColumnName("VSOURCEROWNO");
            this.Property(t => t.VSOURCEWASTCODE).HasColumnName("VSOURCEWASTCODE");
            this.Property(t => t.VSOURCEWASTROWNO).HasColumnName("VSOURCEWASTROWNO");
            this.Property(t => t.VSRC2BILLCODE).HasColumnName("VSRC2BILLCODE");
            this.Property(t => t.VSRC2BILLROWNO).HasColumnName("VSRC2BILLROWNO");
            this.Property(t => t.VTRANSFERCODE).HasColumnName("VTRANSFERCODE");
            this.Property(t => t.VTRANSTYPEU8RM).HasColumnName("VTRANSTYPEU8RM");
            this.Property(t => t.VVEHICLECODE).HasColumnName("VVEHICLECODE");
        }
    }
}
