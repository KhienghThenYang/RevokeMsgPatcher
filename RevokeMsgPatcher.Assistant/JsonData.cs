﻿using RevokeMsgPatcher.Model;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace RevokeMsgPatcher
{
    /// <summary>
    /// 补丁信息
    /// </summary>
    public class JsonData
    {

        public Bag Bag()
        {
            return new Bag
            {
                Apps = AppConfig(),
                LatestVersion = "0.6",
                Notice = "公告"
            };
        }

        public string BagJson()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(Bag());
        }

        public Dictionary<string, App> AppConfig()
        {
            return new Dictionary<string, App>
            {
                { "Wechat" , Wechat() },
                { "QQ" , QQ() },
                { "TIM" , TIM() },
                { "QQLite" , QQLite() }
            };
        }

        public string AppConfigJson()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(AppConfig());
        }

        public App Wechat()
        {
            return new App
            {
                Name = "Wechat",
                FileTargetInfos = new Dictionary<string, TargetInfo>
                {
                    {
                        "WeChatWin.dll",
                        new TargetInfo
                        {
                            Name = "WeChatWin.dll",
                            RelativePath = "WeChatWin.dll"
                        }
                    }
                },
                FileModifyInfos = new Dictionary<string, List<ModifyInfo>>
                {
                    {
                        "WeChatWin.dll",
                        new List<ModifyInfo>
                        {
                            new ModifyInfo {
                                Name="WeChatWin.dll",
                                Version="2.7.1.85",
                                SHA1Before="de0df4e138b72460450f66c029e33f4510f5e2df",
                                SHA1After="fbd35720aaff3cdcfd3ff18ea503dc06450e5c99",
                                Changes = new List<Change>
                                {
                                    new Change
                                    {
                                        Position =0x00262389,
                                        Content =new byte[] { 0xEB }
                                    },
                                    new Change
                                    {
                                        Position =0x00795680,
                                        Content =new byte[] { 0xC3 }
                                    }
                                }
                            },
                            new ModifyInfo {
                                Name="WeChatWin.dll",
                                Version="2.7.1.82",
                                SHA1Before="20e111a18872bf6c7148a897c11da26c1ec95520",
                                SHA1After="1e0741d325ca6b1cd2402b829a3d13a2524af617",
                                Changes = new List<Change>
                                {
                                    new Change
                                    {
                                        Position =0x00262389,
                                        Content =new byte[] { 0xEB }
                                    },
                                    new Change
                                    {
                                        Position =0x00795650,
                                        Content =new byte[] { 0xC3 }
                                    }
                                }
                            },
                            new ModifyInfo {
                                Name="WeChatWin.dll",
                                Version="2.7.1.74",
                                SHA1Before="b1eaf7edc074a88be5d0f89230436cc2084d24d2",
                                SHA1After="eb3d74ccd87a09059a005f4972861898fc3de463",
                                Changes = new List<Change>
                                {
                                    new Change
                                    {
                                        Position =0x00262389,
                                        Content =new byte[] { 0xEB }
                                    },
                                    new Change
                                    {
                                        Position =0x00795550,
                                        Content =new byte[] { 0xC3 }
                                    }
                                }
                            },
                            new ModifyInfo {
                                Name="WeChatWin.dll",
                                Version="2.7.1.65",
                                SHA1Before="8346b97d264725da924d240c6eb77df3e693385e",
                                SHA1After="42bab2c9c79ef4f2088c00ea6d817973e14a5e6e",
                                Changes = new List<Change>
                                {
                                    new Change
                                    {
                                        Position =2495545,
                                        Content =new byte[] { 235}
                                    }
                                }
                            },
                            new ModifyInfo {Name="WeChatWin.dll",Version="2.7.1.59",SHA1Before="df954d403edaca89cd5394927a325a0023e93281",SHA1After="6aa22460c91bb5c5e2f0ec1af99b8a5f6d4318c0",Changes = new List<Change> { new Change {Position=2496073,Content=new byte[] { 235} } } },new ModifyInfo {Name="WeChatWin.dll",Version="2.7.1.43",SHA1Before="39cd9e09e1a3eac09e6808749bff525c9e3216ce",SHA1After="7b829f1ff0217e346a80f9510fdd7634ddd49445",Changes = new List<Change> { new Change {Position=2494169,Content=new byte[] { 235} } } },new ModifyInfo {Name="WeChatWin.dll",Version="2.7.0.70",SHA1Before="3b0601864aff3c1d792f812ad1ca05f02aa761e3",SHA1After="1e8734d32b0a8c12758e30f99c77f729991fb071",Changes = new List<Change> { new Change {Position=2475657,Content=new byte[] { 235} } } },new ModifyInfo {Name="WeChatWin.dll",Version="2.7.0.65",SHA1Before="063c2e05a0df1bdb8987c2d978d93499bd2052ba",SHA1After="5ed4c09a4f18643b967f063a824d7e65d0567f8a",Changes = new List<Change> { new Change {Position=2475449,Content=new byte[] { 117} } } },new ModifyInfo {Name="WeChatWin.dll",Version="2.6.8.68",SHA1Before="2e9417f4276b12fe32ca7b4fee49272a4a2af334",SHA1After="699602ee3cbb9ae5714f6e6ebc658c875a6c66e6",Changes = new List<Change> { new Change {Position=2454006,Content=new byte[] { 116} } } },new ModifyInfo {Name="WeChatWin.dll",Version="2.6.8.65",SHA1Before="e01f6855a96c12c30808960903ed199a33e4952c",SHA1After="d9120569cfd0433aebea107d7b90805cbbac7518",Changes = new List<Change> { new Change {Position=2454265,Content=new byte[] { 117} } } },new ModifyInfo {Name="WeChatWin.dll",Version="2.6.8.52",SHA1Before="88131302f664df6a657c9ca49d152da536fe5729",SHA1After="8d1454b73831644181e962c1fa0ea4e2da4124a3",Changes = new List<Change> { new Change {Position=2453049,Content=new byte[] { 117} } } },new ModifyInfo {Name="WeChatWin.dll",Version="2.6.8.51",SHA1Before="d0a5517b1292a751501b00b4b1f0702db2d9fc30",SHA1After="53e7b1525d49bf2c3250a8131ff0ba2510779b78",Changes = new List<Change> { new Change {Position=2452614,Content=new byte[] { 116} } } },new ModifyInfo {Name="WeChatWin.dll",Version="2.6.8.37",SHA1Before="7e01f8b04a158a4a50bc5a6e67c2fb8b02233170",SHA1After="a1895004415fe9bcd7e690bd6e482b833b515599",Changes = new List<Change> { new Change {Position=2452614,Content=new byte[] { 116} } } },new ModifyInfo {Name="WeChatWin.dll",Version="2.6.7.57",SHA1Before="80a91aaf941bcb1c24a7d672838ac73e9ebb2e40",SHA1After="a0d3f9a45a835f97aef7fe0872387d8cfb5c25a4",Changes = new List<Change> { new Change {Position=2433413,Content=new byte[] { 116} } } },new ModifyInfo {Name="WeChatWin.dll",Version="2.6.7.40",SHA1Before="04bd0cb28df6630b518f42a3f9c2caa4a9359fbc",SHA1After="13c91cf1d4609959771fd137b9a86a5ca365e1b6",Changes = new List<Change> { new Change {Position=2432934,Content=new byte[] { 116} } } },new ModifyInfo {Name="WeChatWin.dll",Version="2.6.7.32",SHA1Before="a02519c1007ee6723947c262c720d63c619f633e",SHA1After="f3007471ca8734c29783c25f0bb49949a783a44",Changes = new List<Change> { new Change {Position=2432806,Content=new byte[] { 116} } } },new ModifyInfo {Name="WeChatWin.dll",Version="2.6.6.28",SHA1Before="0b19cb17a62c3ea0efce0fb675a1d3b17845cba3",SHA1After="260948656725446b818ea668273ceff02ddfb44d",Changes = new List<Change> { new Change {Position=2401678,Content=new byte[] { 116} } } }
                        }
                    }
                }
            };
        }

        public App QQ()
        {
            return new App
            {
                Name = "QQ",
                FileTargetInfos = new Dictionary<string, TargetInfo>
                {
                    {
                        "IM.dll",
                        new TargetInfo
                        {
                            Name = "IM.dll",
                            RelativePath = @"Bin\IM.dll"
                        }
                    }
                },
                FileModifyInfos = new Dictionary<string, List<ModifyInfo>>
                {
                    {
                        "IM.dll",
                        new List<ModifyInfo>
                        {
                            new ModifyInfo
                            {
                                Name = "IM.dll",
                                Version = "9.2.0.26389",
                                SHA1Before = "6f8855fb80acfa456f8f69989fe949308fe4d154",
                                SHA1After = "f6b8e05a178b9b10ba17c597fa0a44b7a2a966a8",
                                Changes = new List<Change>
                                {
                                    new Change
                                    {
                                        Position = 0x000571C8,
                                        Content = new byte[] { 0xEB, 0x09, 0x90, 0x90, 0x90 }
                                    },
                                    new Change
                                    {
                                        Position = 0x000573E5,
                                        Content = new byte[] { 0xEB, 0x09, 0x90, 0x90, 0x90 }
                                    },
                                    new Change
                                    {
                                        Position = 0x00057595,
                                        Content = new byte[] { 0xEB, 0x08, 0x90, 0x90, 0x90, 0x90 }
                                    }
                                }
                            },
                            new ModifyInfo
                            {
                                Name = "IM.dll",
                                Version = "9.1.9.26361",
                                SHA1Before = "022d3433d13d07a354c38816f61cb0b7ac60d3fd",
                                SHA1After = "873a57c1fb51cdd099c8cb7108b5ab5cb4459557",
                                Changes = new List<Change>
                                {
                                    new Change
                                    {
                                        Position = 0x000567DE,
                                        Content = new byte[] { 0xEB, 0x09, 0x90, 0x90, 0x90 }
                                    },
                                    new Change
                                    {
                                        Position = 0x000569FB,
                                        Content = new byte[] { 0xEB, 0x09, 0x90, 0x90, 0x90 }
                                    },
                                    new Change
                                    {
                                        Position = 0x00056BAB,
                                        Content = new byte[] { 0xEB, 0x08, 0x90, 0x90, 0x90, 0x90 }
                                    }
                                }
                            },
                            new ModifyInfo
                            {
                                Name = "IM.dll",
                                Version = "9.1.9.26346",
                                SHA1Before = "895eb70f707b8222e6460c91492b1281e525059b",
                                SHA1After = "0bb83990e2b5b5f23b7b43249941ff638201af54",
                                Changes = new List<Change>
                                {
                                    new Change
                                    {
                                        Position = 0x000567DE,
                                        Content = new byte[] { 0xEB, 0x09, 0x90, 0x90, 0x90 }
                                    },
                                    new Change
                                    {
                                        Position = 0x000569FB,
                                        Content = new byte[] { 0xEB, 0x09, 0x90, 0x90, 0x90 }
                                    },
                                    new Change
                                    {
                                        Position = 0x00056BAB,
                                        Content = new byte[] { 0xEB, 0x08, 0x90, 0x90, 0x90, 0x90 }
                                    }
                                }
                            },
                            new ModifyInfo
                            {
                                Name = "IM.dll",
                                Version = "9.1.8.26211",
                                SHA1Before = "a950d3cf5e8925f7775624271105ef78d9c5cb57",
                                SHA1After = "dffc1cb87b91e6467e13c935611f2f7fd76b9a8d",
                                Changes = new List<Change>
                                {
                                    new Change
                                    {
                                        Position = 0x000524EF,
                                        Content = new byte[] { 0xEB, 0x09, 0x90, 0x90, 0x90 }
                                    },
                                    new Change
                                    {
                                        Position = 0x0005270C,
                                        Content = new byte[] { 0xEB, 0x09, 0x90, 0x90, 0x90 }
                                    },
                                    new Change
                                    {
                                        Position = 0x000528BC,
                                        Content = new byte[] { 0xEB, 0x08, 0x90, 0x90, 0x90, 0x90 }
                                    }
                                }
                            },
                            new ModifyInfo
                            {
                                Name = "IM.dll",
                                Version = "9.1.7.25980",
                                SHA1Before = "c6632339fbe675312a70ae4620e70699c258cd36",
                                SHA1After = "e9ddc5cc681950796fc8fe4c55f580428c890b51",
                                Changes = new List<Change>
                                {
                                    new Change
                                    {
                                        Position = 0x0005009F,
                                        Content = new byte[] { 0xEB, 0x09, 0x90, 0x90, 0x90 }
                                    },
                                    new Change
                                    {
                                        Position = 0x000502BC,
                                        Content = new byte[] { 0xEB, 0x09, 0x90, 0x90, 0x90 }
                                    },
                                    new Change
                                    {
                                        Position = 0x0005046C,
                                        Content = new byte[] { 0xEB, 0x08, 0x90, 0x90, 0x90, 0x90 }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }

        public App TIM()
        {
            return new App
            {
                Name = "TIM",
                FileTargetInfos = new Dictionary<string, TargetInfo>
                {
                    {
                        "IM.dll",
                        new TargetInfo
                        {
                            Name = "IM.dll",
                            RelativePath = @"Bin\IM.dll"
                        }
                    }
                },
                FileModifyInfos = new Dictionary<string, List<ModifyInfo>>
                {
                    {
                        "IM.dll",
                        new List<ModifyInfo>
                        {
                            new ModifyInfo
                            {
                                Name = "IM.dll",
                                Version = "2.3.2.21173",
                                SHA1Before = "ecf3e69f3fb100ffe2fee095ffded591b9781024",
                                SHA1After = "0514d1304e7ac46b4d33386ec3313888f5ae7171",
                                Changes = new List<Change>
                                {
                                    new Change
                                    {
                                        Position = 0x0004D78A,
                                        Content = new byte[] { 0xEB, 0x09, 0x90, 0x90, 0x90 }
                                    },
                                    new Change
                                    {
                                        Position = 0x0004D9A7,
                                        Content = new byte[] { 0xEB, 0x09, 0x90, 0x90, 0x90 }
                                    },
                                    new Change
                                    {
                                        Position = 0x0004DB57,
                                        Content = new byte[] { 0xEB, 0x08, 0x90, 0x90, 0x90, 0x90 }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }

        public App QQLite()
        {
            return new App
            {
                Name = "QQLite",
                FileTargetInfos = new Dictionary<string, TargetInfo>
                {
                    {
                        "IM.dll",
                        new TargetInfo
                        {
                            Name = "IM.dll",
                            RelativePath = @"Bin\IM.dll"
                        }
                    }
                },
                FileModifyInfos = new Dictionary<string, List<ModifyInfo>>
                {
                    {
                        "IM.dll",
                        new List<ModifyInfo>
                        {
                            new ModifyInfo
                            {
                                Name = "IM.dll",
                                Version = "7.9.14314.0",
                                SHA1Before = "2e97d7671963fa148a1beeda6ce4964314310593",
                                SHA1After = "723c008fb53435ead20fa6f2e951c9a4a8ff46da",
                                Changes = new List<Change>
                                {
                                    new Change
                                    {
                                        Position = 0x00024505,
                                        Content = new byte[] { 0xEB, 0x02, 0x90, 0x90 }
                                    },
                                    new Change
                                    {
                                        Position = 0x000248B9,
                                        Content = new byte[] { 0xEB, 0x02, 0x90, 0x90 }
                                    }
                                }
                            },
                            new ModifyInfo
                            {
                                Name = "IM.dll",
                                Version = "7.9.14308.0",
                                SHA1Before = "b8a7a873178706b97be11c25f13bcf09e9e578a2",
                                SHA1After = "c5bf533c7af6996b42d1fb2a0fb3f26dfd52f8bf",
                                Changes = new List<Change>
                                {
                                    new Change
                                    {
                                        Position = 0x00024505,
                                        Content = new byte[] { 0xEB, 0x02, 0x90, 0x90 }
                                    },
                                    new Change
                                    {
                                        Position = 0x000248B9,
                                        Content = new byte[] { 0xEB, 0x02, 0x90, 0x90 }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
