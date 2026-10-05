using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Activity;
using Torappu.AVG;
using Torappu.Grading;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003809 RID: 14345
	[Token(Token = "0x2003809")]
	public class UILocalCache : Singleton<UILocalCache>, IHotfixable
	{
		// Token: 0x06016B8D RID: 93069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B8D")]
		[Address(RVA = "0xF1B0D0", Offset = "0xF19CD0", VA = "0x180F1B0D0")]
		protected UILocalCache()
		{
		}

		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x06016B8E RID: 93070 RVA: 0x000927A8 File Offset: 0x000909A8
		// (set) Token: 0x06016B8F RID: 93071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003653")]
		public int lastSelectedSquadIndex
		{
			[Token(Token = "0x6016B8E")]
			[Address(RVA = "0xF1BD20", Offset = "0xF1A920", VA = "0x180F1BD20")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016B8F")]
			[Address(RVA = "0xF1CC40", Offset = "0xF1B840", VA = "0x180F1CC40")]
			set
			{
			}
		}

		// Token: 0x06016B90 RID: 93072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B90")]
		[Address(RVA = "0xF1A850", Offset = "0xF19450", VA = "0x180F1A850")]
		public void SetSkillSelectablePredefinedSquadTipsShowed(string activityId)
		{
		}

		// Token: 0x06016B91 RID: 93073 RVA: 0x000927C0 File Offset: 0x000909C0
		[Token(Token = "0x6016B91")]
		[Address(RVA = "0xF18430", Offset = "0xF17030", VA = "0x180F18430")]
		public bool CheckSkillSelectablePredefinedSquadTipsShowed(string activityId)
		{
			return default(bool);
		}

		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x06016B92 RID: 93074 RVA: 0x000927D8 File Offset: 0x000909D8
		// (set) Token: 0x06016B93 RID: 93075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003654")]
		public int AVGButtonAutoSpeed
		{
			[Token(Token = "0x6016B92")]
			[Address(RVA = "0xF1B1F0", Offset = "0xF19DF0", VA = "0x180F1B1F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016B93")]
			[Address(RVA = "0xF1C080", Offset = "0xF1AC80", VA = "0x180F1C080")]
			set
			{
			}
		}

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x06016B94 RID: 93076 RVA: 0x000927F0 File Offset: 0x000909F0
		// (set) Token: 0x06016B95 RID: 93077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003655")]
		public int AVGQuickAutoSpeed
		{
			[Token(Token = "0x6016B94")]
			[Address(RVA = "0xF1B590", Offset = "0xF1A190", VA = "0x180F1B590")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016B95")]
			[Address(RVA = "0xF1C3F0", Offset = "0xF1AFF0", VA = "0x180F1C3F0")]
			set
			{
			}
		}

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x06016B96 RID: 93078 RVA: 0x00092808 File Offset: 0x00090A08
		// (set) Token: 0x06016B97 RID: 93079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003656")]
		public AVGExecuteMode AVGExecuteMode
		{
			[Token(Token = "0x6016B96")]
			[Address(RVA = "0xF1B480", Offset = "0xF1A080", VA = "0x180F1B480")]
			get
			{
				return AVGExecuteMode.Normal;
			}
			[Token(Token = "0x6016B97")]
			[Address(RVA = "0xF1C2C0", Offset = "0xF1AEC0", VA = "0x180F1C2C0")]
			set
			{
			}
		}

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x06016B98 RID: 93080 RVA: 0x00092820 File Offset: 0x00090A20
		// (set) Token: 0x06016B99 RID: 93081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003657")]
		public bool AVGPureMode
		{
			[Token(Token = "0x6016B98")]
			[Address(RVA = "0xF1B500", Offset = "0xF1A100", VA = "0x180F1B500")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6016B99")]
			[Address(RVA = "0xF1C360", Offset = "0xF1AF60", VA = "0x180F1C360")]
			set
			{
			}
		}

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x06016B9A RID: 93082 RVA: 0x00092838 File Offset: 0x00090A38
		// (set) Token: 0x06016B9B RID: 93083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003658")]
		public int AVGReaderFontSize
		{
			[Token(Token = "0x6016B9A")]
			[Address(RVA = "0xF1B880", Offset = "0xF1A480", VA = "0x180F1B880")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016B9B")]
			[Address(RVA = "0xF1C750", Offset = "0xF1B350", VA = "0x180F1C750")]
			set
			{
			}
		}

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x06016B9C RID: 93084 RVA: 0x00092850 File Offset: 0x00090A50
		// (set) Token: 0x06016B9D RID: 93085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003659")]
		public int AVGReaderLineSpace
		{
			[Token(Token = "0x6016B9C")]
			[Address(RVA = "0xF1B9A0", Offset = "0xF1A5A0", VA = "0x180F1B9A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016B9D")]
			[Address(RVA = "0xF1C870", Offset = "0xF1B470", VA = "0x180F1C870")]
			set
			{
			}
		}

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x06016B9E RID: 93086 RVA: 0x00092868 File Offset: 0x00090A68
		// (set) Token: 0x06016B9F RID: 93087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700365A")]
		public int AVGReaderFontSizeIndex
		{
			[Token(Token = "0x6016B9E")]
			[Address(RVA = "0xF1B810", Offset = "0xF1A410", VA = "0x180F1B810")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016B9F")]
			[Address(RVA = "0xF1C6C0", Offset = "0xF1B2C0", VA = "0x180F1C6C0")]
			set
			{
			}
		}

		// Token: 0x1700365B RID: 13915
		// (get) Token: 0x06016BA0 RID: 93088 RVA: 0x00092880 File Offset: 0x00090A80
		// (set) Token: 0x06016BA1 RID: 93089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700365B")]
		public int AVGReaderLineSpaceIndex
		{
			[Token(Token = "0x6016BA0")]
			[Address(RVA = "0xF1B930", Offset = "0xF1A530", VA = "0x180F1B930")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BA1")]
			[Address(RVA = "0xF1C7E0", Offset = "0xF1B3E0", VA = "0x180F1C7E0")]
			set
			{
			}
		}

		// Token: 0x1700365C RID: 13916
		// (get) Token: 0x06016BA2 RID: 93090 RVA: 0x00092898 File Offset: 0x00090A98
		// (set) Token: 0x06016BA3 RID: 93091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700365C")]
		public int AVGReaderBgAlpha
		{
			[Token(Token = "0x6016BA2")]
			[Address(RVA = "0xF1B750", Offset = "0xF1A350", VA = "0x180F1B750")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BA3")]
			[Address(RVA = "0xF1C630", Offset = "0xF1B230", VA = "0x180F1C630")]
			set
			{
			}
		}

		// Token: 0x1700365D RID: 13917
		// (get) Token: 0x06016BA4 RID: 93092 RVA: 0x000928B0 File Offset: 0x00090AB0
		// (set) Token: 0x06016BA5 RID: 93093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700365D")]
		public int AVGReaderBgAlphaIndex
		{
			[Token(Token = "0x6016BA4")]
			[Address(RVA = "0xF1B6E0", Offset = "0xF1A2E0", VA = "0x180F1B6E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BA5")]
			[Address(RVA = "0xF1C5A0", Offset = "0xF1B1A0", VA = "0x180F1C5A0")]
			set
			{
			}
		}

		// Token: 0x1700365E RID: 13918
		// (get) Token: 0x06016BA6 RID: 93094 RVA: 0x000928C8 File Offset: 0x00090AC8
		// (set) Token: 0x06016BA7 RID: 93095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700365E")]
		public int AVGReaderAutoMode
		{
			[Token(Token = "0x6016BA6")]
			[Address(RVA = "0xF1B600", Offset = "0xF1A200", VA = "0x180F1B600")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BA7")]
			[Address(RVA = "0xF1C480", Offset = "0xF1B080", VA = "0x180F1C480")]
			set
			{
			}
		}

		// Token: 0x1700365F RID: 13919
		// (get) Token: 0x06016BA8 RID: 93096 RVA: 0x000928E0 File Offset: 0x00090AE0
		// (set) Token: 0x06016BA9 RID: 93097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700365F")]
		public int AVGReaderAutoSpeed
		{
			[Token(Token = "0x6016BA8")]
			[Address(RVA = "0xF1B670", Offset = "0xF1A270", VA = "0x180F1B670")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BA9")]
			[Address(RVA = "0xF1C510", Offset = "0xF1B110", VA = "0x180F1C510")]
			set
			{
			}
		}

		// Token: 0x17003660 RID: 13920
		// (get) Token: 0x06016BAA RID: 93098 RVA: 0x000928F8 File Offset: 0x00090AF8
		// (set) Token: 0x06016BAB RID: 93099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003660")]
		public int GridGachaSkipAnimation
		{
			[Token(Token = "0x6016BAA")]
			[Address(RVA = "0xF1BAC0", Offset = "0xF1A6C0", VA = "0x180F1BAC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BAB")]
			[Address(RVA = "0xF1C990", Offset = "0xF1B590", VA = "0x180F1C990")]
			set
			{
			}
		}

		// Token: 0x17003661 RID: 13921
		// (get) Token: 0x06016BAC RID: 93100 RVA: 0x00092910 File Offset: 0x00090B10
		// (set) Token: 0x06016BAD RID: 93101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003661")]
		public int AVGDialogFontSize
		{
			[Token(Token = "0x6016BAC")]
			[Address(RVA = "0xF1B2D0", Offset = "0xF19ED0", VA = "0x180F1B2D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BAD")]
			[Address(RVA = "0xF1C1A0", Offset = "0xF1ADA0", VA = "0x180F1C1A0")]
			set
			{
			}
		}

		// Token: 0x17003662 RID: 13922
		// (get) Token: 0x06016BAE RID: 93102 RVA: 0x00092928 File Offset: 0x00090B28
		// (set) Token: 0x06016BAF RID: 93103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003662")]
		public int AVGDialogFontSizeIndex
		{
			[Token(Token = "0x6016BAE")]
			[Address(RVA = "0xF1B260", Offset = "0xF19E60", VA = "0x180F1B260")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BAF")]
			[Address(RVA = "0xF1C110", Offset = "0xF1AD10", VA = "0x180F1C110")]
			set
			{
			}
		}

		// Token: 0x17003663 RID: 13923
		// (get) Token: 0x06016BB0 RID: 93104 RVA: 0x00092940 File Offset: 0x00090B40
		// (set) Token: 0x06016BB1 RID: 93105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003663")]
		public int AVGDialogPresetId
		{
			[Token(Token = "0x6016BB0")]
			[Address(RVA = "0xF1B390", Offset = "0xF19F90", VA = "0x180F1B390")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BB1")]
			[Address(RVA = "0xF1C230", Offset = "0xF1AE30", VA = "0x180F1C230")]
			set
			{
			}
		}

		// Token: 0x17003664 RID: 13924
		// (get) Token: 0x06016BB2 RID: 93106 RVA: 0x00092958 File Offset: 0x00090B58
		// (set) Token: 0x06016BB3 RID: 93107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003664")]
		public int serverAnnouceVersion
		{
			[Token(Token = "0x6016BB2")]
			[Address(RVA = "0xF1BF50", Offset = "0xF1AB50", VA = "0x180F1BF50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BB3")]
			[Address(RVA = "0xF1CEE0", Offset = "0xF1BAE0", VA = "0x180F1CEE0")]
			set
			{
			}
		}

		// Token: 0x17003665 RID: 13925
		// (get) Token: 0x06016BB4 RID: 93108 RVA: 0x00092970 File Offset: 0x00090B70
		// (set) Token: 0x06016BB5 RID: 93109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003665")]
		public int localAnnouceVersion
		{
			[Token(Token = "0x6016BB4")]
			[Address(RVA = "0xF1BD90", Offset = "0xF1A990", VA = "0x180F1BD90")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BB5")]
			[Address(RVA = "0xF1CCD0", Offset = "0xF1B8D0", VA = "0x180F1CCD0")]
			set
			{
			}
		}

		// Token: 0x17003666 RID: 13926
		// (get) Token: 0x06016BB6 RID: 93110 RVA: 0x00092988 File Offset: 0x00090B88
		// (set) Token: 0x06016BB7 RID: 93111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003666")]
		public int serverPopUpAnnouceVersion
		{
			[Token(Token = "0x6016BB6")]
			[Address(RVA = "0xF1BFB0", Offset = "0xF1ABB0", VA = "0x180F1BFB0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BB7")]
			[Address(RVA = "0xF1CF50", Offset = "0xF1BB50", VA = "0x180F1CF50")]
			set
			{
			}
		}

		// Token: 0x17003667 RID: 13927
		// (get) Token: 0x06016BB8 RID: 93112 RVA: 0x000929A0 File Offset: 0x00090BA0
		// (set) Token: 0x06016BB9 RID: 93113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003667")]
		public int localPopUpAnnouceVersion
		{
			[Token(Token = "0x6016BB8")]
			[Address(RVA = "0xF1BE00", Offset = "0xF1AA00", VA = "0x180F1BE00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BB9")]
			[Address(RVA = "0xF1CD60", Offset = "0xF1B960", VA = "0x180F1CD60")]
			set
			{
			}
		}

		// Token: 0x17003668 RID: 13928
		// (get) Token: 0x06016BBA RID: 93114 RVA: 0x000929B8 File Offset: 0x00090BB8
		// (set) Token: 0x06016BBB RID: 93115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003668")]
		public static bool medalCacheBarListStateFlag
		{
			[Token(Token = "0x6016BBA")]
			[Address(RVA = "0xF1BE70", Offset = "0xF1AA70", VA = "0x180F1BE70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6016BBB")]
			[Address(RVA = "0xF1CDF0", Offset = "0xF1B9F0", VA = "0x180F1CDF0")]
			set
			{
			}
		}

		// Token: 0x17003669 RID: 13929
		// (get) Token: 0x06016BBC RID: 93116 RVA: 0x000929D0 File Offset: 0x00090BD0
		// (set) Token: 0x06016BBD RID: 93117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003669")]
		public static int fifthAnnivExploreCarouselCount
		{
			[Token(Token = "0x6016BBC")]
			[Address(RVA = "0xF1BB30", Offset = "0xF1A730", VA = "0x180F1BB30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BBD")]
			[Address(RVA = "0xF1CA20", Offset = "0xF1B620", VA = "0x180F1CA20")]
			set
			{
			}
		}

		// Token: 0x1700366A RID: 13930
		// (get) Token: 0x06016BBE RID: 93118 RVA: 0x000929E8 File Offset: 0x00090BE8
		// (set) Token: 0x06016BBF RID: 93119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700366A")]
		public static bool medalShowExpiredStatus
		{
			[Token(Token = "0x6016BBE")]
			[Address(RVA = "0xF1BEE0", Offset = "0xF1AAE0", VA = "0x180F1BEE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6016BBF")]
			[Address(RVA = "0xF1CE70", Offset = "0xF1BA70", VA = "0x180F1CE70")]
			set
			{
			}
		}

		// Token: 0x1700366B RID: 13931
		// (get) Token: 0x06016BC0 RID: 93120 RVA: 0x00092A00 File Offset: 0x00090C00
		// (set) Token: 0x06016BC1 RID: 93121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700366B")]
		public GradingController.GradingLevel gradingLevel
		{
			[Token(Token = "0x6016BC0")]
			[Address(RVA = "0xF1BCA0", Offset = "0xF1A8A0", VA = "0x180F1BCA0")]
			get
			{
				return GradingController.GradingLevel.NODEFINE;
			}
			[Token(Token = "0x6016BC1")]
			[Address(RVA = "0xF1CBB0", Offset = "0xF1B7B0", VA = "0x180F1CBB0")]
			set
			{
			}
		}

		// Token: 0x1700366C RID: 13932
		// (get) Token: 0x06016BC2 RID: 93122 RVA: 0x00092A18 File Offset: 0x00090C18
		// (set) Token: 0x06016BC3 RID: 93123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700366C")]
		public GradingController.SimulatorStatus gradingIsSimulator
		{
			[Token(Token = "0x6016BC2")]
			[Address(RVA = "0xF1BBA0", Offset = "0xF1A7A0", VA = "0x180F1BBA0")]
			get
			{
				return GradingController.SimulatorStatus.NODEFINE;
			}
			[Token(Token = "0x6016BC3")]
			[Address(RVA = "0xF1CA90", Offset = "0xF1B690", VA = "0x180F1CA90")]
			set
			{
			}
		}

		// Token: 0x1700366D RID: 13933
		// (get) Token: 0x06016BC4 RID: 93124 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06016BC5 RID: 93125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700366D")]
		public string gradingLastUpdateVersion
		{
			[Token(Token = "0x6016BC4")]
			[Address(RVA = "0xF1BC20", Offset = "0xF1A820", VA = "0x180F1BC20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6016BC5")]
			[Address(RVA = "0xF1CB20", Offset = "0xF1B720", VA = "0x180F1CB20")]
			set
			{
			}
		}

		// Token: 0x1700366E RID: 13934
		// (get) Token: 0x06016BC6 RID: 93126 RVA: 0x00092A30 File Offset: 0x00090C30
		// (set) Token: 0x06016BC7 RID: 93127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700366E")]
		public int serviceLicenseVersion
		{
			[Token(Token = "0x6016BC6")]
			[Address(RVA = "0xF1C010", Offset = "0xF1AC10", VA = "0x180F1C010")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BC7")]
			[Address(RVA = "0xF1CFC0", Offset = "0xF1BBC0", VA = "0x180F1CFC0")]
			set
			{
			}
		}

		// Token: 0x06016BC8 RID: 93128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BC8")]
		[Address(RVA = "0xF180D0", Offset = "0xF16CD0", VA = "0x180F180D0")]
		public void AddPreAnnounceId(string announceId)
		{
		}

		// Token: 0x06016BC9 RID: 93129 RVA: 0x00092A48 File Offset: 0x00090C48
		[Token(Token = "0x6016BC9")]
		[Address(RVA = "0xF18310", Offset = "0xF16F10", VA = "0x180F18310")]
		public bool CheckPreAnnounceId(string announceId)
		{
			return default(bool);
		}

		// Token: 0x06016BCA RID: 93130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016BCA")]
		[Address(RVA = "0xF1ADE0", Offset = "0xF199E0", VA = "0x180F1ADE0")]
		private string _GenPreAnnounceKey(string key)
		{
			return null;
		}

		// Token: 0x06016BCB RID: 93131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BCB")]
		[Address(RVA = "0xF18160", Offset = "0xF16D60", VA = "0x180F18160")]
		public void AddRetroNewFlag(string retroId)
		{
		}

		// Token: 0x06016BCC RID: 93132 RVA: 0x00092A60 File Offset: 0x00090C60
		[Token(Token = "0x6016BCC")]
		[Address(RVA = "0xF183A0", Offset = "0xF16FA0", VA = "0x180F183A0")]
		public bool CheckRetroNewFlag(string retroId)
		{
			return default(bool);
		}

		// Token: 0x06016BCD RID: 93133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016BCD")]
		[Address(RVA = "0xF1AF00", Offset = "0xF19B00", VA = "0x180F1AF00")]
		private string _GenRetroKey(string key)
		{
			return null;
		}

		// Token: 0x06016BCE RID: 93134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BCE")]
		[Address(RVA = "0xF19E90", Offset = "0xF18A90", VA = "0x180F19E90")]
		public void SetCharSortType(CharacterSortType sortType)
		{
		}

		// Token: 0x06016BCF RID: 93135 RVA: 0x00092A78 File Offset: 0x00090C78
		[Token(Token = "0x6016BCF")]
		[Address(RVA = "0xF188A0", Offset = "0xF174A0", VA = "0x180F188A0")]
		public CharacterSortType GetCharSortType()
		{
			return CharacterSortType.BY_LEVEL_UP;
		}

		// Token: 0x06016BD0 RID: 93136 RVA: 0x00092A90 File Offset: 0x00090C90
		[Token(Token = "0x6016BD0")]
		[Address(RVA = "0xF18BD0", Offset = "0xF177D0", VA = "0x180F18BD0")]
		public bool GetIsPlayerRepoStarTopMode(int defaultType = -1)
		{
			return default(bool);
		}

		// Token: 0x06016BD1 RID: 93137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BD1")]
		[Address(RVA = "0xF1A520", Offset = "0xF19120", VA = "0x180F1A520")]
		public void SetPlayerRepoStarTopMode(bool isStarMarkTop)
		{
		}

		// Token: 0x06016BD2 RID: 93138 RVA: 0x00092AA8 File Offset: 0x00090CA8
		[Token(Token = "0x6016BD2")]
		[Address(RVA = "0xF18A00", Offset = "0xF17600", VA = "0x180F18A00")]
		public bool GetIfLoginDynEntrancePlayed(long timestamp, string dynIllustId)
		{
			return default(bool);
		}

		// Token: 0x06016BD3 RID: 93139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BD3")]
		[Address(RVA = "0xF1A2B0", Offset = "0xF18EB0", VA = "0x180F1A2B0")]
		public void SetLoginDynEntrancePlayed(long timestamp, string dynIllustId)
		{
		}

		// Token: 0x06016BD4 RID: 93140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BD4")]
		[Address(RVA = "0xF1AA30", Offset = "0xF19630", VA = "0x180F1AA30")]
		private void _EnsurePlayedDynIllustCache(long timestamp)
		{
		}

		// Token: 0x06016BD5 RID: 93141 RVA: 0x00092AC0 File Offset: 0x00090CC0
		[Token(Token = "0x6016BD5")]
		[Address(RVA = "0xF19120", Offset = "0xF17D20", VA = "0x180F19120")]
		public bool GetShowHomeBirthdaySetting()
		{
			return default(bool);
		}

		// Token: 0x06016BD6 RID: 93142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BD6")]
		[Address(RVA = "0xF1A7C0", Offset = "0xF193C0", VA = "0x180F1A7C0")]
		public void SetShowHomeBirthdaySetting(bool isShow)
		{
		}

		// Token: 0x06016BD7 RID: 93143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BD7")]
		[Address(RVA = "0xF19FA0", Offset = "0xF18BA0", VA = "0x180F19FA0")]
		public void SetDiffGroupRewardAutoShow(bool ableToShow)
		{
		}

		// Token: 0x06016BD8 RID: 93144 RVA: 0x00092AD8 File Offset: 0x00090CD8
		[Token(Token = "0x6016BD8")]
		[Address(RVA = "0xF18980", Offset = "0xF17580", VA = "0x180F18980")]
		public bool GetDiffGroupRewardAutoShow()
		{
			return default(bool);
		}

		// Token: 0x06016BD9 RID: 93145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BD9")]
		[Address(RVA = "0xF19F10", Offset = "0xF18B10", VA = "0x180F19F10")]
		public void SetDiffGroupAutoSelect(StageDiffGroup diffGroup)
		{
		}

		// Token: 0x06016BDA RID: 93146 RVA: 0x00092AF0 File Offset: 0x00090CF0
		[Token(Token = "0x6016BDA")]
		[Address(RVA = "0xF18910", Offset = "0xF17510", VA = "0x180F18910")]
		public StageDiffGroup GetDiffGroupAutoSelect()
		{
			return StageDiffGroup.NONE;
		}

		// Token: 0x1700366F RID: 13935
		// (get) Token: 0x06016BDB RID: 93147 RVA: 0x00092B08 File Offset: 0x00090D08
		// (set) Token: 0x06016BDC RID: 93148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700366F")]
		public int DiffGroupAutoSelect
		{
			[Token(Token = "0x6016BDB")]
			[Address(RVA = "0xF1BA50", Offset = "0xF1A650", VA = "0x180F1BA50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016BDC")]
			[Address(RVA = "0xF1C900", Offset = "0xF1B500", VA = "0x180F1C900")]
			set
			{
			}
		}

		// Token: 0x06016BDD RID: 93149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BDD")]
		[Address(RVA = "0xF1A740", Offset = "0xF19340", VA = "0x180F1A740")]
		public void SetSecretaryChangeSortType(CharacterSortType sortType)
		{
		}

		// Token: 0x06016BDE RID: 93150 RVA: 0x00092B20 File Offset: 0x00090D20
		[Token(Token = "0x6016BDE")]
		[Address(RVA = "0xF190B0", Offset = "0xF17CB0", VA = "0x180F190B0")]
		public CharacterSortType GetSecretaryChangeSortType()
		{
			return CharacterSortType.BY_LEVEL_UP;
		}

		// Token: 0x06016BDF RID: 93151 RVA: 0x00092B38 File Offset: 0x00090D38
		[Token(Token = "0x6016BDF")]
		[Address(RVA = "0xF18C60", Offset = "0xF17860", VA = "0x180F18C60")]
		public bool GetIsPlayerSecretaryChangeStarTopMode()
		{
			return default(bool);
		}

		// Token: 0x06016BE0 RID: 93152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BE0")]
		[Address(RVA = "0xF1A5B0", Offset = "0xF191B0", VA = "0x180F1A5B0")]
		public void SetPlayerSecretaryChangeStarTopMode(bool isStarMarkTop)
		{
		}

		// Token: 0x06016BE1 RID: 93153 RVA: 0x00092B50 File Offset: 0x00090D50
		[Token(Token = "0x6016BE1")]
		[Address(RVA = "0xF18EF0", Offset = "0xF17AF0", VA = "0x180F18EF0")]
		public int GetPlayerCharSelectCustomSortTypeWithKey(string key, int defaultType = -1)
		{
			return 0;
		}

		// Token: 0x06016BE2 RID: 93154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BE2")]
		[Address(RVA = "0xF1A470", Offset = "0xF19070", VA = "0x180F1A470")]
		public void SetPlayerCharSelectCustomSortTypeWithKey(string key, int customType)
		{
		}

		// Token: 0x06016BE3 RID: 93155 RVA: 0x00092B68 File Offset: 0x00090D68
		[Token(Token = "0x6016BE3")]
		[Address(RVA = "0xF18B50", Offset = "0xF17750", VA = "0x180F18B50")]
		public bool GetIsPlayerRepoFilterPanelShow()
		{
			return default(bool);
		}

		// Token: 0x06016BE4 RID: 93156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BE4")]
		[Address(RVA = "0xF1A0C0", Offset = "0xF18CC0", VA = "0x180F1A0C0")]
		public void SetIsPlayerRepoFilterPanelShow(bool isSortPanelShow)
		{
		}

		// Token: 0x06016BE5 RID: 93157 RVA: 0x00092B80 File Offset: 0x00090D80
		[Token(Token = "0x6016BE5")]
		[Address(RVA = "0xF18AD0", Offset = "0xF176D0", VA = "0x180F18AD0")]
		public bool GetIsPlayerCharSelectFilterPanelShow()
		{
			return default(bool);
		}

		// Token: 0x06016BE6 RID: 93158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BE6")]
		[Address(RVA = "0xF1A030", Offset = "0xF18C30", VA = "0x180F1A030")]
		public void SetIsPlayerCharSelectFilterPanelShow(bool isFilterPanelShow)
		{
		}

		// Token: 0x06016BE7 RID: 93159 RVA: 0x00092B98 File Offset: 0x00090D98
		[Token(Token = "0x6016BE7")]
		[Address(RVA = "0xF18FA0", Offset = "0xF17BA0", VA = "0x180F18FA0")]
		public int GetPlayerStarMarkTopMode(int defaultMode = -1)
		{
			return 0;
		}

		// Token: 0x06016BE8 RID: 93160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BE8")]
		[Address(RVA = "0xF1A640", Offset = "0xF19240", VA = "0x180F1A640")]
		public void SetPlayerStarMarkTopMode(int defaultMode)
		{
		}

		// Token: 0x06016BE9 RID: 93161 RVA: 0x00092BB0 File Offset: 0x00090DB0
		[Token(Token = "0x6016BE9")]
		[Address(RVA = "0xF19030", Offset = "0xF17C30", VA = "0x180F19030")]
		public bool GetSOCharReviewedState()
		{
			return default(bool);
		}

		// Token: 0x06016BEA RID: 93162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BEA")]
		[Address(RVA = "0xF1A6D0", Offset = "0xF192D0", VA = "0x180F1A6D0")]
		public void SetSOCharReviewedState()
		{
		}

		// Token: 0x06016BEB RID: 93163 RVA: 0x00092BC8 File Offset: 0x00090DC8
		[Token(Token = "0x6016BEB")]
		[Address(RVA = "0xF191A0", Offset = "0xF17DA0", VA = "0x180F191A0")]
		public bool GetSquadStarFriendTabSelected()
		{
			return default(bool);
		}

		// Token: 0x06016BEC RID: 93164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BEC")]
		[Address(RVA = "0xF1A8F0", Offset = "0xF194F0", VA = "0x180F1A8F0")]
		public void SetSquadStarFriendTabSelected(bool isStarFirst)
		{
		}

		// Token: 0x06016BED RID: 93165 RVA: 0x00092BE0 File Offset: 0x00090DE0
		[Token(Token = "0x6016BED")]
		[Address(RVA = "0xF194C0", Offset = "0xF180C0", VA = "0x180F194C0")]
		public bool IsMultiplayerSquadCopied(string activityId, string groupId)
		{
			return default(bool);
		}

		// Token: 0x06016BEE RID: 93166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BEE")]
		[Address(RVA = "0xF1A3C0", Offset = "0xF18FC0", VA = "0x180F1A3C0")]
		public void SetMultiplayerSquadCopied(string activityId, string groupId)
		{
		}

		// Token: 0x06016BEF RID: 93167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016BEF")]
		[Address(RVA = "0xF1B020", Offset = "0xF19C20", VA = "0x180F1B020")]
		private string _GetMultiplayerSquadCopyKey(string activityId, string groupId)
		{
			return null;
		}

		// Token: 0x06016BF0 RID: 93168 RVA: 0x00092BF8 File Offset: 0x00090DF8
		[Token(Token = "0x6016BF0")]
		[Address(RVA = "0xF19430", Offset = "0xF18030", VA = "0x180F19430")]
		public bool IsAntiSpoilerVisited(string antiSpoilerId)
		{
			return default(bool);
		}

		// Token: 0x06016BF1 RID: 93169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BF1")]
		[Address(RVA = "0xF19C50", Offset = "0xF18850", VA = "0x180F19C50")]
		public void SetAntiSpoilerChecked(string antiSpoilerId)
		{
		}

		// Token: 0x06016BF2 RID: 93170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016BF2")]
		[Address(RVA = "0xF1AF90", Offset = "0xF19B90", VA = "0x180F1AF90")]
		private string _GetAntiSpoilerChecked(string antiSpoilerId)
		{
			return null;
		}

		// Token: 0x06016BF3 RID: 93171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016BF3")]
		public SquadType LoadRuneSquadCacheV1<SquadType>(string squadSaveKey) where SquadType : new()
		{
			return null;
		}

		// Token: 0x06016BF4 RID: 93172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BF4")]
		public void SaveRuneSquadCacheV1<SquadType>(string squadSaveKey, SquadType squadData)
		{
		}

		// Token: 0x06016BF5 RID: 93173 RVA: 0x00092C10 File Offset: 0x00090E10
		[Token(Token = "0x6016BF5")]
		[Address(RVA = "0xF193A0", Offset = "0xF17FA0", VA = "0x180F193A0")]
		public bool GuideOnlyCheckGuidebookViewed(string key)
		{
			return default(bool);
		}

		// Token: 0x06016BF6 RID: 93174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BF6")]
		[Address(RVA = "0xF19310", Offset = "0xF17F10", VA = "0x180F19310")]
		public void GuideOnlyAddGuidebookViewed(string key)
		{
		}

		// Token: 0x06016BF7 RID: 93175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016BF7")]
		[Address(RVA = "0xF1AD50", Offset = "0xF19950", VA = "0x180F1AD50")]
		private string _GenGuidebookKey(string key)
		{
			return null;
		}

		// Token: 0x06016BF8 RID: 93176 RVA: 0x00092C28 File Offset: 0x00090E28
		[Token(Token = "0x6016BF8")]
		[Address(RVA = "0xF18560", Offset = "0xF17160", VA = "0x180F18560")]
		public bool EnemyViewedCheck(string key)
		{
			return default(bool);
		}

		// Token: 0x06016BF9 RID: 93177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BF9")]
		[Address(RVA = "0xF184D0", Offset = "0xF170D0", VA = "0x180F184D0")]
		public void EnemyAddViewed(string key)
		{
		}

		// Token: 0x06016BFA RID: 93178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016BFA")]
		[Address(RVA = "0xF1ACC0", Offset = "0xF198C0", VA = "0x180F1ACC0")]
		private string _GenEnemyKey(string key)
		{
			return null;
		}

		// Token: 0x06016BFB RID: 93179 RVA: 0x00092C40 File Offset: 0x00090E40
		[Token(Token = "0x6016BFB")]
		[Address(RVA = "0xF19800", Offset = "0xF18400", VA = "0x180F19800")]
		public bool RecommendShopViewedCheck(string key)
		{
			return default(bool);
		}

		// Token: 0x06016BFC RID: 93180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BFC")]
		[Address(RVA = "0xF19770", Offset = "0xF18370", VA = "0x180F19770")]
		public void RecommendShopAddViewed(string key)
		{
		}

		// Token: 0x06016BFD RID: 93181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016BFD")]
		[Address(RVA = "0xF1AE70", Offset = "0xF19A70", VA = "0x180F1AE70")]
		private string _GenRecommendShopKey(string key)
		{
			return null;
		}

		// Token: 0x06016BFE RID: 93182 RVA: 0x00092C58 File Offset: 0x00090E58
		[Token(Token = "0x6016BFE")]
		[Address(RVA = "0xF18CD0", Offset = "0xF178D0", VA = "0x180F18CD0")]
		public long GetLastExtraClickTime(long currentLastClick)
		{
			return 0L;
		}

		// Token: 0x06016BFF RID: 93183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016BFF")]
		[Address(RVA = "0xF1A150", Offset = "0xF18D50", VA = "0x180F1A150")]
		public void SetLastExtraClickTime(long currentLastClick)
		{
		}

		// Token: 0x06016C00 RID: 93184 RVA: 0x00092C70 File Offset: 0x00090E70
		[Token(Token = "0x6016C00")]
		[Address(RVA = "0xF181F0", Offset = "0xF16DF0", VA = "0x180F181F0")]
		public bool AnnouceViewedCheck(string key)
		{
			return default(bool);
		}

		// Token: 0x06016C01 RID: 93185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C01")]
		[Address(RVA = "0xF18280", Offset = "0xF16E80", VA = "0x180F18280")]
		public void AnnounceAddViewed(string key)
		{
		}

		// Token: 0x06016C02 RID: 93186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016C02")]
		[Address(RVA = "0xF1AC30", Offset = "0xF19830", VA = "0x180F1AC30")]
		private string _GenAnnounceKey(string key)
		{
			return null;
		}

		// Token: 0x06016C03 RID: 93187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C03")]
		[Address(RVA = "0xF19E00", Offset = "0xF18A00", VA = "0x180F19E00")]
		public void SetCampaignCachedRotateStageId(string stageId)
		{
		}

		// Token: 0x06016C04 RID: 93188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016C04")]
		[Address(RVA = "0xF18780", Offset = "0xF17380", VA = "0x180F18780")]
		public string GetCampaignCachedRotateStageId()
		{
			return null;
		}

		// Token: 0x06016C05 RID: 93189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C05")]
		[Address(RVA = "0xF19D70", Offset = "0xF18970", VA = "0x180F19D70")]
		public void SetCampaignCachedBriefId(string briefId)
		{
		}

		// Token: 0x06016C06 RID: 93190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016C06")]
		[Address(RVA = "0xF18710", Offset = "0xF17310", VA = "0x180F18710")]
		public string GetCampaignCachedBriefId()
		{
			return null;
		}

		// Token: 0x06016C07 RID: 93191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016C07")]
		[Address(RVA = "0xF19630", Offset = "0xF18230", VA = "0x180F19630")]
		public Dictionary<string, StageViewModel.LocalCache> LoadStageCache()
		{
			return null;
		}

		// Token: 0x06016C08 RID: 93192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C08")]
		[Address(RVA = "0xF19A40", Offset = "0xF18640", VA = "0x180F19A40")]
		public void SaveStageCache(Dictionary<string, StageViewModel.LocalCache> localCache)
		{
		}

		// Token: 0x06016C09 RID: 93193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016C09")]
		[Address(RVA = "0xF196D0", Offset = "0xF182D0", VA = "0x180F196D0")]
		public Dictionary<string, ZoneViewModel.LocalCache> LoadZoneCache()
		{
			return null;
		}

		// Token: 0x06016C0A RID: 93194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C0A")]
		[Address(RVA = "0xF19AF0", Offset = "0xF186F0", VA = "0x180F19AF0")]
		public void SaveZoneCache(Dictionary<string, ZoneViewModel.LocalCache> localCache)
		{
		}

		// Token: 0x06016C0B RID: 93195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016C0B")]
		[Address(RVA = "0xF19570", Offset = "0xF18170", VA = "0x180F19570")]
		public ActivityLocalCache LoadActivityCache()
		{
			return null;
		}

		// Token: 0x06016C0C RID: 93196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C0C")]
		[Address(RVA = "0xF19890", Offset = "0xF18490", VA = "0x180F19890")]
		public void SaveActivityCache(ActivityLocalCache localCache)
		{
		}

		// Token: 0x06016C0D RID: 93197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C0D")]
		[Address(RVA = "0xF1A980", Offset = "0xF19580", VA = "0x180F1A980")]
		public void SetStageMultipleBattleTimesCache(string stageId, int times)
		{
		}

		// Token: 0x06016C0E RID: 93198 RVA: 0x00092C88 File Offset: 0x00090E88
		[Token(Token = "0x6016C0E")]
		[Address(RVA = "0xF19220", Offset = "0xF17E20", VA = "0x180F19220")]
		public int GetStageMultipleBattleTimesCache(string stageId)
		{
			return 0;
		}

		// Token: 0x06016C0F RID: 93199 RVA: 0x00092CA0 File Offset: 0x00090EA0
		[Token(Token = "0x6016C0F")]
		[Address(RVA = "0xF18E20", Offset = "0xF17A20", VA = "0x180F18E20")]
		public long GetLoginCharRotationUpdateTimeStamp()
		{
			return 0L;
		}

		// Token: 0x06016C10 RID: 93200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C10")]
		[Address(RVA = "0xF1A1F0", Offset = "0xF18DF0", VA = "0x180F1A1F0")]
		public void SetLoginCharRotationUpdateTimeStamp(long timestamp)
		{
		}

		// Token: 0x06016C11 RID: 93201 RVA: 0x00092CB8 File Offset: 0x00090EB8
		[Token(Token = "0x6016C11")]
		[Address(RVA = "0xF187F0", Offset = "0xF173F0", VA = "0x180F187F0")]
		public UICharIllustInfoCache.CharRotationInfoSet GetCharRotationInfoSet()
		{
			return default(UICharIllustInfoCache.CharRotationInfoSet);
		}

		// Token: 0x06016C12 RID: 93202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C12")]
		[Address(RVA = "0xF19930", Offset = "0xF18530", VA = "0x180F19930")]
		public void SaveCharRotationInfoSet(string instId, List<string> skinList, int displayIndex)
		{
		}

		// Token: 0x06016C13 RID: 93203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C13")]
		[Address(RVA = "0xF19CE0", Offset = "0xF188E0", VA = "0x180F19CE0")]
		public void SetBuildingMeetingSendClueFilterStat(bool isOn)
		{
		}

		// Token: 0x06016C14 RID: 93204 RVA: 0x00092CD0 File Offset: 0x00090ED0
		[Token(Token = "0x6016C14")]
		[Address(RVA = "0xF18690", Offset = "0xF17290", VA = "0x180F18690")]
		public bool GetBuildingMeetingSendClueFilterStat()
		{
			return default(bool);
		}

		// Token: 0x06016C15 RID: 93205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C15")]
		[Address(RVA = "0xF19BA0", Offset = "0xF187A0", VA = "0x180F19BA0")]
		public void SetAct24sideHuntWikiTabStat(string actId, int index)
		{
		}

		// Token: 0x06016C16 RID: 93206 RVA: 0x00092CE8 File Offset: 0x00090EE8
		[Token(Token = "0x6016C16")]
		[Address(RVA = "0xF185F0", Offset = "0xF171F0", VA = "0x180F185F0")]
		public int GetAct24sideHuntWikiTabStat(string actId)
		{
			return 0;
		}

		// Token: 0x0401B608 RID: 112136
		[Token(Token = "0x401B608")]
		private const string LAST_SELECTED_SQUAD = "key_last_selected_squad";

		// Token: 0x0401B609 RID: 112137
		[Token(Token = "0x401B609")]
		private const string AVG_BUTTON_AUTO_SPEED = "key_avg_button_auto_speed";

		// Token: 0x0401B60A RID: 112138
		[Token(Token = "0x401B60A")]
		private const string AVG_QUICK_AUTO_SPEED = "key_avg_quick_auto_speed";

		// Token: 0x0401B60B RID: 112139
		[Token(Token = "0x401B60B")]
		private const string AVG_EXECUTE_MODE_KEY = "avg_execute_mode";

		// Token: 0x0401B60C RID: 112140
		[Token(Token = "0x401B60C")]
		private const string AVG_PURE_MODE_KEY = "avg_pure_mode";

		// Token: 0x0401B60D RID: 112141
		[Token(Token = "0x401B60D")]
		private const string AVG_READER_FONT_SIZE_KEY = "avg_reader_font_size";

		// Token: 0x0401B60E RID: 112142
		[Token(Token = "0x401B60E")]
		private const string AVG_READER_LINE_SPACE_KEY = "avg_reader_line_space";

		// Token: 0x0401B60F RID: 112143
		[Token(Token = "0x401B60F")]
		private const string AVG_READER_FONT_SIZE_INDEX_KEY = "avg_reader_font_size_index";

		// Token: 0x0401B610 RID: 112144
		[Token(Token = "0x401B610")]
		private const string AVG_READER_LINE_SPACE_INDEX_KEY = "avg_reader_line_space_index";

		// Token: 0x0401B611 RID: 112145
		[Token(Token = "0x401B611")]
		private const string AVG_READER_BG_ALPHA_KEY = "avg_reader_bg_alpha";

		// Token: 0x0401B612 RID: 112146
		[Token(Token = "0x401B612")]
		private const string AVG_READER_BG_ALPHA_INDEX_KEY = "avg_reader_bg_alpha_index";

		// Token: 0x0401B613 RID: 112147
		[Token(Token = "0x401B613")]
		private const string AVG_READER_AUTO_MODE_KEY = "avg_reader_auto_mode";

		// Token: 0x0401B614 RID: 112148
		[Token(Token = "0x401B614")]
		private const string AVG_READER_AUTO_SPEED_KEY = "avg_reader_auto_speed";

		// Token: 0x0401B615 RID: 112149
		[Token(Token = "0x401B615")]
		private const string AVG_DIALOG_FONT_SIZE_KEY = "avg_dialog_font_size";

		// Token: 0x0401B616 RID: 112150
		[Token(Token = "0x401B616")]
		private const string AVG_DIALOG_FONT_SIZE_INDEX_KEY = "avg_dialog_font_size_index";

		// Token: 0x0401B617 RID: 112151
		[Token(Token = "0x401B617")]
		private const string AVG_DIALOG_PRESET_ID_KEY = "avg_dialog_preset_id";

		// Token: 0x0401B618 RID: 112152
		[Token(Token = "0x401B618")]
		private const string GRID_GACHA_SKIP_ANIMATION = "key_grid_gacha_skip_animation";

		// Token: 0x0401B619 RID: 112153
		[Token(Token = "0x401B619")]
		private const string HOME_ANNOUNCE_VERSION = "key_home_annouce_version";

		// Token: 0x0401B61A RID: 112154
		[Token(Token = "0x401B61A")]
		private const string HOME_ANNOUNCE_POP_UP_VERSION = "key_home_annouce_pop_up_version";

		// Token: 0x0401B61B RID: 112155
		[Token(Token = "0x401B61B")]
		private const string MEDAL_BAR_LIST_STATE_CACHE_ENTER = "key_medal_bar_list_state_cache_enter";

		// Token: 0x0401B61C RID: 112156
		[Token(Token = "0x401B61C")]
		private const string FIFTH_ANNIV_EXPLORE_CAROUSEL_ITEM = "key_fifth_anniv_explore_carousel";

		// Token: 0x0401B61D RID: 112157
		[Token(Token = "0x401B61D")]
		private const string MEDAL_SHOW_EXPIRED = "key_medal_show_expired";

		// Token: 0x0401B61E RID: 112158
		[Token(Token = "0x401B61E")]
		private const string STAGE_LOCAL_CACHE = "key_stage_local_cache";

		// Token: 0x0401B61F RID: 112159
		[Token(Token = "0x401B61F")]
		private const string ZONE_LOCAL_CACHE = "key_zone_local_cache";

		// Token: 0x0401B620 RID: 112160
		[Token(Token = "0x401B620")]
		public const string ACT_LOCAL_CACHE = "key_act_local_cache";

		// Token: 0x0401B621 RID: 112161
		[Token(Token = "0x401B621")]
		public const string RETRO_LOCAL_CACHE = "key_retro_local_cache#{0}";

		// Token: 0x0401B622 RID: 112162
		[Token(Token = "0x401B622")]
		private const string GUIDEBOOK_VIEWED = "key_GB_viewed#{0}";

		// Token: 0x0401B623 RID: 112163
		[Token(Token = "0x401B623")]
		private const string ANNOUNCE_VIEWED = "key_home_announce_viewed#{0}";

		// Token: 0x0401B624 RID: 112164
		[Token(Token = "0x401B624")]
		private const string ENEMY_VIEWED = "key_enemy_viewed#{0}";

		// Token: 0x0401B625 RID: 112165
		[Token(Token = "0x401B625")]
		private const string SHOP_RECOMMEND_VIEWED = "key_shop_recommend#{0}";

		// Token: 0x0401B626 RID: 112166
		[Token(Token = "0x401B626")]
		private const string SHOP_EXTRA_QC_VIEWED = "key_shop_extra_qc_viewed";

		// Token: 0x0401B627 RID: 112167
		[Token(Token = "0x401B627")]
		private const string PRE_ANNOUNCED_VIEWED_GROUP = "key_pre_announce_viewed#{0}";

		// Token: 0x0401B628 RID: 112168
		[Token(Token = "0x401B628")]
		private const string GRADING_LEVEL = "key_grading_level";

		// Token: 0x0401B629 RID: 112169
		[Token(Token = "0x401B629")]
		private const string GRADING_IS_SIMULATOR = "key_grading_is_simulator";

		// Token: 0x0401B62A RID: 112170
		[Token(Token = "0x401B62A")]
		private const string GRADING_LAST_UPDATE_VERSION = "key_grading_last_update_version";

		// Token: 0x0401B62B RID: 112171
		[Token(Token = "0x401B62B")]
		private const string SERVICE_LICENSE_VERSION = "key_service_license_version";

		// Token: 0x0401B62C RID: 112172
		[Token(Token = "0x401B62C")]
		private const string LOCAL_RUNE_SQUAD_TEMPLATE_V1 = "key_local_rune_squad_[{0}]_v1";

		// Token: 0x0401B62D RID: 112173
		[Token(Token = "0x401B62D")]
		private const string CRISIS_PERM_RUNE_USE_SPARSE_MODE = "key_crisis_perm_rune_use_sparse_mode";

		// Token: 0x0401B62E RID: 112174
		[Token(Token = "0x401B62E")]
		private const string CRISIS_SELECTED_RUNES = "key_crisis_selected_runes_{0}";

		// Token: 0x0401B62F RID: 112175
		[Token(Token = "0x401B62F")]
		private const string CRISIS_RUNE_GROUP_SELECTED_RUNES = "key_rune_group_id_{0}";

		// Token: 0x0401B630 RID: 112176
		[Token(Token = "0x401B630")]
		public const string HOME_ILLUST_LAYOUT_INFO = "home_illust_layout_info";

		// Token: 0x0401B631 RID: 112177
		[Token(Token = "0x401B631")]
		private const string CAMP_CACHED_ROTATE_STAGE_ID = "camp_cached_rotate_stage_id";

		// Token: 0x0401B632 RID: 112178
		[Token(Token = "0x401B632")]
		private const string CAMP_CACHED_BRIEF_ID = "camp_cached_brief_id";

		// Token: 0x0401B633 RID: 112179
		[Token(Token = "0x401B633")]
		private const string UNIEQUIP_CHAR_FIRST_VISIT = "uniequip_char_first_visit_{0}";

		// Token: 0x0401B634 RID: 112180
		[Token(Token = "0x401B634")]
		private const string MULTIPLAYER_SQUAD_COPY = "multiplayer_squad_copy_{0}_{1}";

		// Token: 0x0401B635 RID: 112181
		[Token(Token = "0x401B635")]
		private const string ANTI_SPOLIER_KEY = "anti_spolier_{0}";

		// Token: 0x0401B636 RID: 112182
		[Token(Token = "0x401B636")]
		private const string DIFF_GROUP_AUTO_SHOW = "diff_group_auto_show";

		// Token: 0x0401B637 RID: 112183
		[Token(Token = "0x401B637")]
		private const string DIFF_GROUP_AUTO_SELECT = "diff_group_auto_select";

		// Token: 0x0401B638 RID: 112184
		[Token(Token = "0x401B638")]
		public const string RECENT_BATTLE_RECORDS = "key_ui_recent_battle_records";

		// Token: 0x0401B639 RID: 112185
		[Token(Token = "0x401B639")]
		public const string UI_MUSIC_TRIGGER_CACHE = "key_ui_music_trigger_cache";

		// Token: 0x0401B63A RID: 112186
		[Token(Token = "0x401B63A")]
		public const string UI_COMMON_TRK_PT = "key_ui_common_trk_pt";

		// Token: 0x0401B63B RID: 112187
		[Token(Token = "0x401B63B")]
		public const string UI_MUSIC_CONFIG_CACHE = "key_ui_music_config_cache";

		// Token: 0x0401B63C RID: 112188
		[Token(Token = "0x401B63C")]
		public const string ACT_ARCHIVE_LOCAL_CACHE = "key_act_archive_local_cache";

		// Token: 0x0401B63D RID: 112189
		[Token(Token = "0x401B63D")]
		public const string STORY_REVIEW_MINI_TRIAL_LOCAL_CACHE = "key_mini_trial_local_cache";

		// Token: 0x0401B63E RID: 112190
		[Token(Token = "0x401B63E")]
		public const string UI_CHAR_CUSTOM_SORT_TYPE_KEY = "key_ui_char_{0}_custom_sort_type";

		// Token: 0x0401B63F RID: 112191
		[Token(Token = "0x401B63F")]
		public const string UI_CHAR_STARMARK_TOP_LOCAL_CACHE = "key_ui_char_startop_mode";

		// Token: 0x0401B640 RID: 112192
		[Token(Token = "0x401B640")]
		public const string UI_REPO_STARMARK_TOP = "key_ui_repo_startop_mode";

		// Token: 0x0401B641 RID: 112193
		[Token(Token = "0x401B641")]
		public const string UI_ROGUE_LOCALCACHE = "ui_rogue_localcache";

		// Token: 0x0401B642 RID: 112194
		[Token(Token = "0x401B642")]
		public const string UI_CLIMB_TOWER_LOCAL_CACHE = "ui_climbtower_localcache";

		// Token: 0x0401B643 RID: 112195
		[Token(Token = "0x401B643")]
		public const string UI_SQUAD_PREDEFINED_TIPS_SHOWED = "key_ui_squad_predefined_tips_showed_{0}";

		// Token: 0x0401B644 RID: 112196
		[Token(Token = "0x401B644")]
		public const string UI_RES_PREF_ALERT = "key_ui_res_pref_alert";

		// Token: 0x0401B645 RID: 112197
		[Token(Token = "0x401B645")]
		public const string UI_CHAR_SELECT_FILTER_SHOW = "key_ui_char_select_filter_show";

		// Token: 0x0401B646 RID: 112198
		[Token(Token = "0x401B646")]
		public const string UI_REPO_FILTER_SHOW = "key_ui_repo_filter_show";

		// Token: 0x0401B647 RID: 112199
		[Token(Token = "0x401B647")]
		public const string LOGIN_DYN_ENTRANCE_PLAY = "key_login_dyn_entrance_play";

		// Token: 0x0401B648 RID: 112200
		[Token(Token = "0x401B648")]
		public const string UI_BOSS_RUSH_LOCAL_CACHE = "key_ui_boss_rush_localcache";

		// Token: 0x0401B649 RID: 112201
		[Token(Token = "0x401B649")]
		public const string UI_SANDBOX_LOCAL_CACHE = "ui_sandbox_localcache";

		// Token: 0x0401B64A RID: 112202
		[Token(Token = "0x401B64A")]
		public const string UI_SIRACUSA_MAP_LOCAL_CACHE = "key_ui_siracusa_map_localcache";

		// Token: 0x0401B64B RID: 112203
		[Token(Token = "0x401B64B")]
		public const string UI_CRISIS_V2_LOCAL_CACHE = "key_crisis_v2_localcache";

		// Token: 0x0401B64C RID: 112204
		[Token(Token = "0x401B64C")]
		public const string UI_ACT24SIDE_LOCAL_CACHE = "key_act24side_localcache";

		// Token: 0x0401B64D RID: 112205
		[Token(Token = "0x401B64D")]
		public const string UI_ACT42D0_LOCAL_CACHE = "key_ui_act42d0_localcache";

		// Token: 0x0401B64E RID: 112206
		[Token(Token = "0x401B64E")]
		public const string UI_TUNING_LOCAL_CACHE = "key_ui_tuning_localcache";

		// Token: 0x0401B64F RID: 112207
		[Token(Token = "0x401B64F")]
		public const string UI_SANDBOX_V2_LOCAL_CACHE = "ui_sandbox_v2_localcache";

		// Token: 0x0401B650 RID: 112208
		[Token(Token = "0x401B650")]
		private const string STAGE_MULTIPLE_BATTLE_TIMES_LOCAL_CACHE = "key_mulitple_battle_times_{0}";

		// Token: 0x0401B651 RID: 112209
		[Token(Token = "0x401B651")]
		private const string YEAR_5_EXPLORE_IS_NEW = "key_year5_explore_is_new";

		// Token: 0x0401B652 RID: 112210
		[Token(Token = "0x401B652")]
		public const string UI_HOME_BIRTHDAY_SETTING = "key_home_birthday_setting";

		// Token: 0x0401B653 RID: 112211
		[Token(Token = "0x401B653")]
		public const string UI_VEC_BREAK_V2_LOCAL_CACHE = "key_ui_vec_break_v2_localcache";

		// Token: 0x0401B654 RID: 112212
		[Token(Token = "0x401B654")]
		public const string UI_ACT_MULTI_V3_LOCAL_CACHE = "key_ui_act_multi_v3_localcache";

		// Token: 0x0401B655 RID: 112213
		[Token(Token = "0x401B655")]
		public const string UI_ACT1VAUTOCHESS_LOCAL_CACHE = "key_ui_act1vautochess_localcache";

		// Token: 0x0401B656 RID: 112214
		[Token(Token = "0x401B656")]
		public const string UI_GUN_TASK_LOCAL_CACHE = "key_ui_gun_task_localcache";

		// Token: 0x0401B657 RID: 112215
		[Token(Token = "0x401B657")]
		public const string UI_EMOTICON_THEME_LOCAL_CACHE = "key_emoticon_theme_last_gain";

		// Token: 0x0401B658 RID: 112216
		[Token(Token = "0x401B658")]
		public const string UI_ARCADE_LOCAL_CACHE = "key_ui_arcade_localcache";

		// Token: 0x0401B659 RID: 112217
		[Token(Token = "0x401B659")]
		public const string UI_CHAR_ROTATION_LOCAL_CACHE = "key_ui_char_rotation_localcache";

		// Token: 0x0401B65A RID: 112218
		[Token(Token = "0x401B65A")]
		public const string UI_CHAR_ROTATION_LAST_LOGIN = "key_ui_char_rotation_last_login";

		// Token: 0x0401B65B RID: 112219
		[Token(Token = "0x401B65B")]
		public const string UI_MIX_STORY = "key_ui_mix_story";

		// Token: 0x0401B65C RID: 112220
		[Token(Token = "0x401B65C")]
		public const string UI_SIX_STAR_LOCAL_CACHE = "key_ui_six_star_local_cache";

		// Token: 0x0401B65D RID: 112221
		[Token(Token = "0x401B65D")]
		public const string UI_ENEMY_DUEL_LOCAL_CACHE = "key_ui_enemy_duel_localcache";

		// Token: 0x0401B65E RID: 112222
		[Token(Token = "0x401B65E")]
		public const string UI_SOCHAR_MISSION_VIEWER = "key_ui_sochar_mission";

		// Token: 0x0401B65F RID: 112223
		[Token(Token = "0x401B65F")]
		public const string UI_RECAL_RUNE_LOCAL_CACHE = "key_ui_recal_rune_localcache";

		// Token: 0x0401B660 RID: 112224
		[Token(Token = "0x401B660")]
		public const string UI_ACT1VHALFIDLE_LOCAL_CACHE = "key_ui_act1vHalfIdle_localcache";

		// Token: 0x0401B661 RID: 112225
		[Token(Token = "0x401B661")]
		public const string UI_MONOPOLY_LOCAL_CACHE = "key_ui_monopoly_localcache";

		// Token: 0x0401B662 RID: 112226
		[Token(Token = "0x401B662")]
		public const string UI_SQUAD_STAR_FRIEND_ASSIST_FIRST = "key_ui_squad_star_friend_assist_first";

		// Token: 0x0401B663 RID: 112227
		[Token(Token = "0x401B663")]
		public const string UI_AUTOCHESS_LOCAL_CACHE = "key_ui_autochess_localcache";

		// Token: 0x0401B664 RID: 112228
		[Token(Token = "0x401B664")]
		public const string UI_BUILDING_MEETING_SEND_CLUE_FILTER_STAT = "key_ui_building_meeting_send_clue_filter_stat";

		// Token: 0x0401B665 RID: 112229
		[Token(Token = "0x401B665")]
		public const string UI_ART_MAGAZINE_LOCAL_CACHE = "key_ui_art_magazine_localcache";

		// Token: 0x0401B666 RID: 112230
		[Token(Token = "0x401B666")]
		public const string UI_ACT24SIDE_HUNT_WIKI_TAB_LOCAL_CACHE = "key_ui_{0}_hunt_wiki_localcache";

		// Token: 0x0401B667 RID: 112231
		[Token(Token = "0x401B667")]
		[FieldOffset(Offset = "0x10")]
		private UILocalCache.LocalCharSortFilterSetting m_repoSettingCache;

		// Token: 0x0401B668 RID: 112232
		[Token(Token = "0x401B668")]
		[FieldOffset(Offset = "0x18")]
		private UILocalCache.LocalCharSortFilterSetting m_secretaryChangeSettingCache;

		// Token: 0x0401B669 RID: 112233
		[Token(Token = "0x401B669")]
		[FieldOffset(Offset = "0x20")]
		private DynIllustStartMgr.DynIllustLocalCache m_dynIllustCache;

		// Token: 0x0401B66A RID: 112234
		[Token(Token = "0x401B66A")]
		[FieldOffset(Offset = "0x28")]
		private int m_serverAnnouceVersion;

		// Token: 0x0401B66B RID: 112235
		[Token(Token = "0x401B66B")]
		[FieldOffset(Offset = "0x2C")]
		private int m_serverPopUpAnnouceVersion;

		// Token: 0x0401B66C RID: 112236
		[Token(Token = "0x401B66C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401B66D RID: 112237
		[Token(Token = "0x401B66D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_lastSelectedSquadIndex;

		// Token: 0x0401B66E RID: 112238
		[Token(Token = "0x401B66E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_lastSelectedSquadIndex;

		// Token: 0x0401B66F RID: 112239
		[Token(Token = "0x401B66F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetSkillSelectablePredefinedSquadTipsShowed;

		// Token: 0x0401B670 RID: 112240
		[Token(Token = "0x401B670")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckSkillSelectablePredefinedSquadTipsShowed;

		// Token: 0x0401B671 RID: 112241
		[Token(Token = "0x401B671")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_AVGButtonAutoSpeed;

		// Token: 0x0401B672 RID: 112242
		[Token(Token = "0x401B672")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_AVGButtonAutoSpeed;

		// Token: 0x0401B673 RID: 112243
		[Token(Token = "0x401B673")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_AVGQuickAutoSpeed;

		// Token: 0x0401B674 RID: 112244
		[Token(Token = "0x401B674")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_AVGQuickAutoSpeed;

		// Token: 0x0401B675 RID: 112245
		[Token(Token = "0x401B675")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_AVGExecuteMode;

		// Token: 0x0401B676 RID: 112246
		[Token(Token = "0x401B676")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_AVGExecuteMode;

		// Token: 0x0401B677 RID: 112247
		[Token(Token = "0x401B677")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_AVGPureMode;

		// Token: 0x0401B678 RID: 112248
		[Token(Token = "0x401B678")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_AVGPureMode;

		// Token: 0x0401B679 RID: 112249
		[Token(Token = "0x401B679")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_AVGReaderFontSize;

		// Token: 0x0401B67A RID: 112250
		[Token(Token = "0x401B67A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_AVGReaderFontSize;

		// Token: 0x0401B67B RID: 112251
		[Token(Token = "0x401B67B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_AVGReaderLineSpace;

		// Token: 0x0401B67C RID: 112252
		[Token(Token = "0x401B67C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_AVGReaderLineSpace;

		// Token: 0x0401B67D RID: 112253
		[Token(Token = "0x401B67D")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_AVGReaderFontSizeIndex;

		// Token: 0x0401B67E RID: 112254
		[Token(Token = "0x401B67E")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_AVGReaderFontSizeIndex;

		// Token: 0x0401B67F RID: 112255
		[Token(Token = "0x401B67F")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_AVGReaderLineSpaceIndex;

		// Token: 0x0401B680 RID: 112256
		[Token(Token = "0x401B680")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_AVGReaderLineSpaceIndex;

		// Token: 0x0401B681 RID: 112257
		[Token(Token = "0x401B681")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_AVGReaderBgAlpha;

		// Token: 0x0401B682 RID: 112258
		[Token(Token = "0x401B682")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_AVGReaderBgAlpha;

		// Token: 0x0401B683 RID: 112259
		[Token(Token = "0x401B683")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_AVGReaderBgAlphaIndex;

		// Token: 0x0401B684 RID: 112260
		[Token(Token = "0x401B684")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_set_AVGReaderBgAlphaIndex;

		// Token: 0x0401B685 RID: 112261
		[Token(Token = "0x401B685")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_AVGReaderAutoMode;

		// Token: 0x0401B686 RID: 112262
		[Token(Token = "0x401B686")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_set_AVGReaderAutoMode;

		// Token: 0x0401B687 RID: 112263
		[Token(Token = "0x401B687")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_AVGReaderAutoSpeed;

		// Token: 0x0401B688 RID: 112264
		[Token(Token = "0x401B688")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_set_AVGReaderAutoSpeed;

		// Token: 0x0401B689 RID: 112265
		[Token(Token = "0x401B689")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_GridGachaSkipAnimation;

		// Token: 0x0401B68A RID: 112266
		[Token(Token = "0x401B68A")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_set_GridGachaSkipAnimation;

		// Token: 0x0401B68B RID: 112267
		[Token(Token = "0x401B68B")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_AVGDialogFontSize;

		// Token: 0x0401B68C RID: 112268
		[Token(Token = "0x401B68C")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_set_AVGDialogFontSize;

		// Token: 0x0401B68D RID: 112269
		[Token(Token = "0x401B68D")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_AVGDialogFontSizeIndex;

		// Token: 0x0401B68E RID: 112270
		[Token(Token = "0x401B68E")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_set_AVGDialogFontSizeIndex;

		// Token: 0x0401B68F RID: 112271
		[Token(Token = "0x401B68F")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_AVGDialogPresetId;

		// Token: 0x0401B690 RID: 112272
		[Token(Token = "0x401B690")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_set_AVGDialogPresetId;

		// Token: 0x0401B691 RID: 112273
		[Token(Token = "0x401B691")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_serverAnnouceVersion;

		// Token: 0x0401B692 RID: 112274
		[Token(Token = "0x401B692")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_set_serverAnnouceVersion;

		// Token: 0x0401B693 RID: 112275
		[Token(Token = "0x401B693")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_localAnnouceVersion;

		// Token: 0x0401B694 RID: 112276
		[Token(Token = "0x401B694")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_set_localAnnouceVersion;

		// Token: 0x0401B695 RID: 112277
		[Token(Token = "0x401B695")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_serverPopUpAnnouceVersion;

		// Token: 0x0401B696 RID: 112278
		[Token(Token = "0x401B696")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_set_serverPopUpAnnouceVersion;

		// Token: 0x0401B697 RID: 112279
		[Token(Token = "0x401B697")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_localPopUpAnnouceVersion;

		// Token: 0x0401B698 RID: 112280
		[Token(Token = "0x401B698")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_set_localPopUpAnnouceVersion;

		// Token: 0x0401B699 RID: 112281
		[Token(Token = "0x401B699")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_medalCacheBarListStateFlag;

		// Token: 0x0401B69A RID: 112282
		[Token(Token = "0x401B69A")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_set_medalCacheBarListStateFlag;

		// Token: 0x0401B69B RID: 112283
		[Token(Token = "0x401B69B")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_get_fifthAnnivExploreCarouselCount;

		// Token: 0x0401B69C RID: 112284
		[Token(Token = "0x401B69C")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_set_fifthAnnivExploreCarouselCount;

		// Token: 0x0401B69D RID: 112285
		[Token(Token = "0x401B69D")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_get_medalShowExpiredStatus;

		// Token: 0x0401B69E RID: 112286
		[Token(Token = "0x401B69E")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_set_medalShowExpiredStatus;

		// Token: 0x0401B69F RID: 112287
		[Token(Token = "0x401B69F")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_get_gradingLevel;

		// Token: 0x0401B6A0 RID: 112288
		[Token(Token = "0x401B6A0")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_set_gradingLevel;

		// Token: 0x0401B6A1 RID: 112289
		[Token(Token = "0x401B6A1")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_get_gradingIsSimulator;

		// Token: 0x0401B6A2 RID: 112290
		[Token(Token = "0x401B6A2")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_set_gradingIsSimulator;

		// Token: 0x0401B6A3 RID: 112291
		[Token(Token = "0x401B6A3")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_get_gradingLastUpdateVersion;

		// Token: 0x0401B6A4 RID: 112292
		[Token(Token = "0x401B6A4")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_set_gradingLastUpdateVersion;

		// Token: 0x0401B6A5 RID: 112293
		[Token(Token = "0x401B6A5")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_get_serviceLicenseVersion;

		// Token: 0x0401B6A6 RID: 112294
		[Token(Token = "0x401B6A6")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_set_serviceLicenseVersion;

		// Token: 0x0401B6A7 RID: 112295
		[Token(Token = "0x401B6A7")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_AddPreAnnounceId;

		// Token: 0x0401B6A8 RID: 112296
		[Token(Token = "0x401B6A8")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_CheckPreAnnounceId;

		// Token: 0x0401B6A9 RID: 112297
		[Token(Token = "0x401B6A9")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__GenPreAnnounceKey;

		// Token: 0x0401B6AA RID: 112298
		[Token(Token = "0x401B6AA")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_AddRetroNewFlag;

		// Token: 0x0401B6AB RID: 112299
		[Token(Token = "0x401B6AB")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_CheckRetroNewFlag;

		// Token: 0x0401B6AC RID: 112300
		[Token(Token = "0x401B6AC")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__GenRetroKey;

		// Token: 0x0401B6AD RID: 112301
		[Token(Token = "0x401B6AD")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_SetCharSortType;

		// Token: 0x0401B6AE RID: 112302
		[Token(Token = "0x401B6AE")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_GetCharSortType;

		// Token: 0x0401B6AF RID: 112303
		[Token(Token = "0x401B6AF")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_GetIsPlayerRepoStarTopMode;

		// Token: 0x0401B6B0 RID: 112304
		[Token(Token = "0x401B6B0")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_SetPlayerRepoStarTopMode;

		// Token: 0x0401B6B1 RID: 112305
		[Token(Token = "0x401B6B1")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_GetIfLoginDynEntrancePlayed;

		// Token: 0x0401B6B2 RID: 112306
		[Token(Token = "0x401B6B2")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_SetLoginDynEntrancePlayed;

		// Token: 0x0401B6B3 RID: 112307
		[Token(Token = "0x401B6B3")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0__EnsurePlayedDynIllustCache;

		// Token: 0x0401B6B4 RID: 112308
		[Token(Token = "0x401B6B4")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_GetShowHomeBirthdaySetting;

		// Token: 0x0401B6B5 RID: 112309
		[Token(Token = "0x401B6B5")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_SetShowHomeBirthdaySetting;

		// Token: 0x0401B6B6 RID: 112310
		[Token(Token = "0x401B6B6")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_SetDiffGroupRewardAutoShow;

		// Token: 0x0401B6B7 RID: 112311
		[Token(Token = "0x401B6B7")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_GetDiffGroupRewardAutoShow;

		// Token: 0x0401B6B8 RID: 112312
		[Token(Token = "0x401B6B8")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_SetDiffGroupAutoSelect;

		// Token: 0x0401B6B9 RID: 112313
		[Token(Token = "0x401B6B9")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_GetDiffGroupAutoSelect;

		// Token: 0x0401B6BA RID: 112314
		[Token(Token = "0x401B6BA")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_get_DiffGroupAutoSelect;

		// Token: 0x0401B6BB RID: 112315
		[Token(Token = "0x401B6BB")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_set_DiffGroupAutoSelect;

		// Token: 0x0401B6BC RID: 112316
		[Token(Token = "0x401B6BC")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_SetSecretaryChangeSortType;

		// Token: 0x0401B6BD RID: 112317
		[Token(Token = "0x401B6BD")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_GetSecretaryChangeSortType;

		// Token: 0x0401B6BE RID: 112318
		[Token(Token = "0x401B6BE")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_GetIsPlayerSecretaryChangeStarTopMode;

		// Token: 0x0401B6BF RID: 112319
		[Token(Token = "0x401B6BF")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_SetPlayerSecretaryChangeStarTopMode;

		// Token: 0x0401B6C0 RID: 112320
		[Token(Token = "0x401B6C0")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_GetPlayerCharSelectCustomSortTypeWithKey;

		// Token: 0x0401B6C1 RID: 112321
		[Token(Token = "0x401B6C1")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_SetPlayerCharSelectCustomSortTypeWithKey;

		// Token: 0x0401B6C2 RID: 112322
		[Token(Token = "0x401B6C2")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_GetIsPlayerRepoFilterPanelShow;

		// Token: 0x0401B6C3 RID: 112323
		[Token(Token = "0x401B6C3")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_SetIsPlayerRepoFilterPanelShow;

		// Token: 0x0401B6C4 RID: 112324
		[Token(Token = "0x401B6C4")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_GetIsPlayerCharSelectFilterPanelShow;

		// Token: 0x0401B6C5 RID: 112325
		[Token(Token = "0x401B6C5")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_SetIsPlayerCharSelectFilterPanelShow;

		// Token: 0x0401B6C6 RID: 112326
		[Token(Token = "0x401B6C6")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_GetPlayerStarMarkTopMode;

		// Token: 0x0401B6C7 RID: 112327
		[Token(Token = "0x401B6C7")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_SetPlayerStarMarkTopMode;

		// Token: 0x0401B6C8 RID: 112328
		[Token(Token = "0x401B6C8")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_GetSOCharReviewedState;

		// Token: 0x0401B6C9 RID: 112329
		[Token(Token = "0x401B6C9")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_SetSOCharReviewedState;

		// Token: 0x0401B6CA RID: 112330
		[Token(Token = "0x401B6CA")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_GetSquadStarFriendTabSelected;

		// Token: 0x0401B6CB RID: 112331
		[Token(Token = "0x401B6CB")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_SetSquadStarFriendTabSelected;

		// Token: 0x0401B6CC RID: 112332
		[Token(Token = "0x401B6CC")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_IsMultiplayerSquadCopied;

		// Token: 0x0401B6CD RID: 112333
		[Token(Token = "0x401B6CD")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_SetMultiplayerSquadCopied;

		// Token: 0x0401B6CE RID: 112334
		[Token(Token = "0x401B6CE")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0__GetMultiplayerSquadCopyKey;

		// Token: 0x0401B6CF RID: 112335
		[Token(Token = "0x401B6CF")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_IsAntiSpoilerVisited;

		// Token: 0x0401B6D0 RID: 112336
		[Token(Token = "0x401B6D0")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_SetAntiSpoilerChecked;

		// Token: 0x0401B6D1 RID: 112337
		[Token(Token = "0x401B6D1")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0__GetAntiSpoilerChecked;

		// Token: 0x0401B6D2 RID: 112338
		[Token(Token = "0x401B6D2")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_LoadRuneSquadCacheV1;

		// Token: 0x0401B6D3 RID: 112339
		[Token(Token = "0x401B6D3")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_SaveRuneSquadCacheV1;

		// Token: 0x0401B6D4 RID: 112340
		[Token(Token = "0x401B6D4")]
		[FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_GuideOnlyCheckGuidebookViewed;

		// Token: 0x0401B6D5 RID: 112341
		[Token(Token = "0x401B6D5")]
		[FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_GuideOnlyAddGuidebookViewed;

		// Token: 0x0401B6D6 RID: 112342
		[Token(Token = "0x401B6D6")]
		[FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0__GenGuidebookKey;

		// Token: 0x0401B6D7 RID: 112343
		[Token(Token = "0x401B6D7")]
		[FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_EnemyViewedCheck;

		// Token: 0x0401B6D8 RID: 112344
		[Token(Token = "0x401B6D8")]
		[FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_EnemyAddViewed;

		// Token: 0x0401B6D9 RID: 112345
		[Token(Token = "0x401B6D9")]
		[FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0__GenEnemyKey;

		// Token: 0x0401B6DA RID: 112346
		[Token(Token = "0x401B6DA")]
		[FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_RecommendShopViewedCheck;

		// Token: 0x0401B6DB RID: 112347
		[Token(Token = "0x401B6DB")]
		[FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_RecommendShopAddViewed;

		// Token: 0x0401B6DC RID: 112348
		[Token(Token = "0x401B6DC")]
		[FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0__GenRecommendShopKey;

		// Token: 0x0401B6DD RID: 112349
		[Token(Token = "0x401B6DD")]
		[FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_GetLastExtraClickTime;

		// Token: 0x0401B6DE RID: 112350
		[Token(Token = "0x401B6DE")]
		[FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_SetLastExtraClickTime;

		// Token: 0x0401B6DF RID: 112351
		[Token(Token = "0x401B6DF")]
		[FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_AnnouceViewedCheck;

		// Token: 0x0401B6E0 RID: 112352
		[Token(Token = "0x401B6E0")]
		[FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_AnnounceAddViewed;

		// Token: 0x0401B6E1 RID: 112353
		[Token(Token = "0x401B6E1")]
		[FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0__GenAnnounceKey;

		// Token: 0x0401B6E2 RID: 112354
		[Token(Token = "0x401B6E2")]
		[FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0_SetCampaignCachedRotateStageId;

		// Token: 0x0401B6E3 RID: 112355
		[Token(Token = "0x401B6E3")]
		[FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0_GetCampaignCachedRotateStageId;

		// Token: 0x0401B6E4 RID: 112356
		[Token(Token = "0x401B6E4")]
		[FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0_SetCampaignCachedBriefId;

		// Token: 0x0401B6E5 RID: 112357
		[Token(Token = "0x401B6E5")]
		[FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0_GetCampaignCachedBriefId;

		// Token: 0x0401B6E6 RID: 112358
		[Token(Token = "0x401B6E6")]
		[FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0_LoadStageCache;

		// Token: 0x0401B6E7 RID: 112359
		[Token(Token = "0x401B6E7")]
		[FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0_SaveStageCache;

		// Token: 0x0401B6E8 RID: 112360
		[Token(Token = "0x401B6E8")]
		[FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0_LoadZoneCache;

		// Token: 0x0401B6E9 RID: 112361
		[Token(Token = "0x401B6E9")]
		[FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0_SaveZoneCache;

		// Token: 0x0401B6EA RID: 112362
		[Token(Token = "0x401B6EA")]
		[FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0_LoadActivityCache;

		// Token: 0x0401B6EB RID: 112363
		[Token(Token = "0x401B6EB")]
		[FieldOffset(Offset = "0x3F8")]
		private static DelegateBridge __Hotfix0_SaveActivityCache;

		// Token: 0x0401B6EC RID: 112364
		[Token(Token = "0x401B6EC")]
		[FieldOffset(Offset = "0x400")]
		private static DelegateBridge __Hotfix0_SetStageMultipleBattleTimesCache;

		// Token: 0x0401B6ED RID: 112365
		[Token(Token = "0x401B6ED")]
		[FieldOffset(Offset = "0x408")]
		private static DelegateBridge __Hotfix0_GetStageMultipleBattleTimesCache;

		// Token: 0x0401B6EE RID: 112366
		[Token(Token = "0x401B6EE")]
		[FieldOffset(Offset = "0x410")]
		private static DelegateBridge __Hotfix0_GetLoginCharRotationUpdateTimeStamp;

		// Token: 0x0401B6EF RID: 112367
		[Token(Token = "0x401B6EF")]
		[FieldOffset(Offset = "0x418")]
		private static DelegateBridge __Hotfix0_SetLoginCharRotationUpdateTimeStamp;

		// Token: 0x0401B6F0 RID: 112368
		[Token(Token = "0x401B6F0")]
		[FieldOffset(Offset = "0x420")]
		private static DelegateBridge __Hotfix0_GetCharRotationInfoSet;

		// Token: 0x0401B6F1 RID: 112369
		[Token(Token = "0x401B6F1")]
		[FieldOffset(Offset = "0x428")]
		private static DelegateBridge __Hotfix0_SaveCharRotationInfoSet;

		// Token: 0x0401B6F2 RID: 112370
		[Token(Token = "0x401B6F2")]
		[FieldOffset(Offset = "0x430")]
		private static DelegateBridge __Hotfix0_SetBuildingMeetingSendClueFilterStat;

		// Token: 0x0401B6F3 RID: 112371
		[Token(Token = "0x401B6F3")]
		[FieldOffset(Offset = "0x438")]
		private static DelegateBridge __Hotfix0_GetBuildingMeetingSendClueFilterStat;

		// Token: 0x0401B6F4 RID: 112372
		[Token(Token = "0x401B6F4")]
		[FieldOffset(Offset = "0x440")]
		private static DelegateBridge __Hotfix0_SetAct24sideHuntWikiTabStat;

		// Token: 0x0401B6F5 RID: 112373
		[Token(Token = "0x401B6F5")]
		[FieldOffset(Offset = "0x448")]
		private static DelegateBridge __Hotfix0_GetAct24sideHuntWikiTabStat;

		// Token: 0x0200380A RID: 14346
		[Token(Token = "0x200380A")]
		public class LocalCharSortFilterSetting : IHotfixable
		{
			// Token: 0x06016C17 RID: 93207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016C17")]
			[Address(RVA = "0xF3A3D0", Offset = "0xF38FD0", VA = "0x180F3A3D0")]
			public LocalCharSortFilterSetting(UILocalCache.LocalCharSortFilterSetting.DefaultType defaultType)
			{
			}

			// Token: 0x06016C18 RID: 93208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016C18")]
			[Address(RVA = "0xF3A1F0", Offset = "0xF38DF0", VA = "0x180F3A1F0")]
			private void _EnsureData()
			{
			}

			// Token: 0x06016C19 RID: 93209 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016C19")]
			[Address(RVA = "0xF3A0F0", Offset = "0xF38CF0", VA = "0x180F3A0F0")]
			private void _ClearInvalidCache()
			{
			}

			// Token: 0x06016C1A RID: 93210 RVA: 0x00092D00 File Offset: 0x00090F00
			[Token(Token = "0x6016C1A")]
			[Address(RVA = "0xF3A340", Offset = "0xF38F40", VA = "0x180F3A340")]
			private bool _UpdateSessionIfDirty()
			{
				return default(bool);
			}

			// Token: 0x06016C1B RID: 93211 RVA: 0x00092D18 File Offset: 0x00090F18
			[Token(Token = "0x6016C1B")]
			[Address(RVA = "0xF39F20", Offset = "0xF38B20", VA = "0x180F39F20")]
			public CharacterSortType GetCharSortTypeCache()
			{
				return CharacterSortType.BY_LEVEL_UP;
			}

			// Token: 0x06016C1C RID: 93212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016C1C")]
			[Address(RVA = "0xF39FF0", Offset = "0xF38BF0", VA = "0x180F39FF0")]
			public void SetCharSortTypeCache(CharacterSortType sortType)
			{
			}

			// Token: 0x06016C1D RID: 93213 RVA: 0x00092D30 File Offset: 0x00090F30
			[Token(Token = "0x6016C1D")]
			[Address(RVA = "0xF39F80", Offset = "0xF38B80", VA = "0x180F39F80")]
			public bool GetIsStarMarkTopMode()
			{
				return default(bool);
			}

			// Token: 0x06016C1E RID: 93214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016C1E")]
			[Address(RVA = "0xF3A070", Offset = "0xF38C70", VA = "0x180F3A070")]
			public void SetIsStarMarkTopMode(bool isStarMarkTop)
			{
			}

			// Token: 0x0401B6F6 RID: 112374
			[Token(Token = "0x401B6F6")]
			[FieldOffset(Offset = "0x10")]
			private CharacterSortType m_cachedSortType;

			// Token: 0x0401B6F7 RID: 112375
			[Token(Token = "0x401B6F7")]
			[FieldOffset(Offset = "0x14")]
			private int m_isCharStarMarkTop;

			// Token: 0x0401B6F8 RID: 112376
			[Token(Token = "0x401B6F8")]
			[FieldOffset(Offset = "0x18")]
			private bool m_isDefault;

			// Token: 0x0401B6F9 RID: 112377
			[Token(Token = "0x401B6F9")]
			[FieldOffset(Offset = "0x1C")]
			private uint m_loginHash;

			// Token: 0x0401B6FA RID: 112378
			[Token(Token = "0x401B6FA")]
			[FieldOffset(Offset = "0x20")]
			private UILocalCache.LocalCharSortFilterSetting.DefaultType m_defaultType;

			// Token: 0x0401B6FB RID: 112379
			[Token(Token = "0x401B6FB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401B6FC RID: 112380
			[Token(Token = "0x401B6FC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__EnsureData;

			// Token: 0x0401B6FD RID: 112381
			[Token(Token = "0x401B6FD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__ClearInvalidCache;

			// Token: 0x0401B6FE RID: 112382
			[Token(Token = "0x401B6FE")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__UpdateSessionIfDirty;

			// Token: 0x0401B6FF RID: 112383
			[Token(Token = "0x401B6FF")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetCharSortTypeCache;

			// Token: 0x0401B700 RID: 112384
			[Token(Token = "0x401B700")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_SetCharSortTypeCache;

			// Token: 0x0401B701 RID: 112385
			[Token(Token = "0x401B701")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetIsStarMarkTopMode;

			// Token: 0x0401B702 RID: 112386
			[Token(Token = "0x401B702")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_SetIsStarMarkTopMode;

			// Token: 0x0200380B RID: 14347
			[Token(Token = "0x200380B")]
			public struct DefaultType
			{
				// Token: 0x0401B703 RID: 112387
				[Token(Token = "0x401B703")]
				[FieldOffset(Offset = "0x0")]
				public CharacterSortType sortType;

				// Token: 0x0401B704 RID: 112388
				[Token(Token = "0x401B704")]
				[FieldOffset(Offset = "0x4")]
				public bool isStarMark;
			}
		}
	}
}
