using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 闽侯县医院门诊系统
{
    public class AddressService
    {
    }
    public class Sheng
    {
        public const string FJ = "福建省";
        public static class Shi
        {
            public const string LY = "龙岩市";
            public const string FZ = "福州市";
            public const string XM = "厦门市";
            public const string PT = "莆田市";
            public const string SM = "三明市";
            public const string QZ = "泉州市";
            public const string ZZ = "漳州市";
            public const string NP = "南平市";
            public const string ND = "宁德市";
            public static class Xian
            {
                /// <summary>
                /// 龙岩市
                /// </summary>
                public const string SH = "上杭县";
                public const string LC = "连城县";
                public const string WP = "武平县";
                public const string CT = "长汀县";
                public const string XL = "新罗区";
                public const string YD = "永定区";
                /// <summary>
                /// 福州市
                /// </summary>
                public const string MH = "闽侯县";
                public const string GL = "鼓楼区";
                public const string TJ = "台江区";
                public const string CS = "仓山区";
                public const string MW = "马尾区";
                public const string JA = "晋安区";
                public const string CL = "长乐区";
                public const string LJ = "连江县";
                public const string LY = "罗源县";
                public const string MQ = "闽清县";
                public const string YT = "永泰县";
                public const string PT = "平潭县";
                public const string FQ = "福清县";
                /// <summary>
                /// 南平市
                /// </summary>
                public const string YP = "延平区";
                public const string JY = "建阳区";
                public const string SC = "顺昌县";
                public const string PC = "蒲城县";
                public const string GZ = "光泽县";
                public const string SX = "松溪县";
                public const string ZH = "政和县";
                /// <summary>
                /// 泉州市
                /// </summary>
                public const string LCQ = "鲤城区";
                public const string FZ = "丰泽区";
                public const string LJQ = "洛江区";
                public const string QG = "泉港区";
                public const string HA = "惠安区";
                public const string AX = "安溪县";
                public const string YC = "永春县";
                public const string DH = "德化县";
                public const string JM = "金门县";
                /// <summary>
                /// 厦门市
                /// </summary>
                public const string SMQ = "思明区";
                public const string HC = "海沧区";
                public const string HL = "湖里区";
                public const string JMQ = "集美区";
                public const string TA = "同安区";
                public const string YA = "翔安区";
            }
        }
        /// <summary>
        /// 获取所有省
        /// </summary>
        /// <returns></returns>
        public static string[] GetAllShengs()
        {
            return new string[] { FJ };
        }
        /// <summary>
        /// 获取所有市
        /// </summary>
        /// <param name="ShengName"></param>
        /// <returns></returns>
        public static string[] GetAllShis(string ShengName)
        {
            switch(ShengName)
            {
                case FJ:
                    {
                        return new string[] { Shi.LY,Shi.FZ,Shi.ND,Shi.NP,Shi.PT,Shi.QZ,Shi.XM,Shi.ZZ,Shi.SM };
                    }
            }
            return null;
        }
        /// <summary>
        /// 获取所有县
        /// </summary>
        /// <param name="ShiName"></param>
        /// <returns></returns>
        public static string[] GetAllXians(string ShiName)
        {
            switch(ShiName)
            {
                case Shi.LY:
                    {
                        return new string[] { Shi.Xian.SH, Shi.Xian.CT, Shi.Xian.LC,
                            Shi.Xian.WP,Shi.Xian.XL,Shi.Xian.YD };
                    }
                case Shi.FZ:
                    {
                        return new string[] {Shi.Xian.MH,Shi.Xian.GL,Shi.Xian.TJ,
                            Shi.Xian.CS,Shi.Xian.MW,Shi.Xian.JA,Shi.Xian.CL,Shi.Xian.LJ,Shi.Xian.MQ,
                        Shi.Xian.YT,Shi.Xian.PT,Shi.Xian.FQ};
                    }
                case Shi.NP:
                    {
                        return new string[] {Shi.Xian.YP,Shi.Xian.JY,Shi.Xian.SC,Shi.Xian.PC
                        ,Shi.Xian.GZ,Shi.Xian.SX,Shi.Xian.ZH};
                    }
                case Shi.QZ:
                    {
                        return new string[] {Shi.Xian.LCQ,Shi.Xian.FZ,Shi.Xian.LJQ,Shi.Xian.QG
                        ,Shi.Xian.HA,Shi.Xian.AX,Shi.Xian.YC,Shi.Xian.DH,Shi.Xian.JM};
                    }
                case Shi.XM:
                    {
                        return new string[] {Shi.Xian.SMQ,Shi.Xian.HC,Shi.Xian.HL,Shi.Xian.JMQ,Shi.Xian.TA
                        ,Shi.Xian.YA};
                    }

            }
            return null;
        }
    }

}
