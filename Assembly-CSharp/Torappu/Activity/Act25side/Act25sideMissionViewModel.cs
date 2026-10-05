using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x0200752B RID: 29995
	[Token(Token = "0x200752B")]
	public class Act25sideMissionViewModel : IHotfixable
	{
		// Token: 0x17006371 RID: 25457
		// (get) Token: 0x0602A426 RID: 173094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006371")]
		public string missionId
		{
			[Token(Token = "0x602A426")]
			[Address(RVA = "0x25DFE60", Offset = "0x25DEA60", VA = "0x1825DFE60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006372 RID: 25458
		// (get) Token: 0x0602A427 RID: 173095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006372")]
		public string areaId
		{
			[Token(Token = "0x602A427")]
			[Address(RVA = "0x25DFC80", Offset = "0x25DE880", VA = "0x1825DFC80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006373 RID: 25459
		// (get) Token: 0x0602A428 RID: 173096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006373")]
		public string bindStageId
		{
			[Token(Token = "0x602A428")]
			[Address(RVA = "0x25DFCE0", Offset = "0x25DE8E0", VA = "0x1825DFCE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006374 RID: 25460
		// (get) Token: 0x0602A429 RID: 173097 RVA: 0x000D7D00 File Offset: 0x000D5F00
		[Token(Token = "0x17006374")]
		public bool isZone
		{
			[Token(Token = "0x602A429")]
			[Address(RVA = "0x25DFE00", Offset = "0x25DEA00", VA = "0x1825DFE00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006375 RID: 25461
		// (get) Token: 0x0602A42A RID: 173098 RVA: 0x000D7D18 File Offset: 0x000D5F18
		[Token(Token = "0x17006375")]
		public int costCount
		{
			[Token(Token = "0x602A42A")]
			[Address(RVA = "0x25DFD40", Offset = "0x25DE940", VA = "0x1825DFD40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006376 RID: 25462
		// (get) Token: 0x0602A42B RID: 173099 RVA: 0x000D7D30 File Offset: 0x000D5F30
		[Token(Token = "0x17006376")]
		public int transform
		{
			[Token(Token = "0x602A42B")]
			[Address(RVA = "0x25DFFE0", Offset = "0x25DEBE0", VA = "0x1825DFFE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006377 RID: 25463
		// (get) Token: 0x0602A42C RID: 173100 RVA: 0x000D7D48 File Offset: 0x000D5F48
		[Token(Token = "0x17006377")]
		public int progress
		{
			[Token(Token = "0x602A42C")]
			[Address(RVA = "0x25DFF20", Offset = "0x25DEB20", VA = "0x1825DFF20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006378 RID: 25464
		// (get) Token: 0x0602A42D RID: 173101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006378")]
		public string progressPicId
		{
			[Token(Token = "0x602A42D")]
			[Address(RVA = "0x25DFEC0", Offset = "0x25DEAC0", VA = "0x1825DFEC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006379 RID: 25465
		// (get) Token: 0x0602A42E RID: 173102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006379")]
		public string desc
		{
			[Token(Token = "0x602A42E")]
			[Address(RVA = "0x25DFDA0", Offset = "0x25DE9A0", VA = "0x1825DFDA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700637A RID: 25466
		// (get) Token: 0x0602A42F RID: 173103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700637A")]
		public List<UIItemViewModel> rewards
		{
			[Token(Token = "0x602A42F")]
			[Address(RVA = "0x25DFF80", Offset = "0x25DEB80", VA = "0x1825DFF80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A430 RID: 173104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A430")]
		[Address(RVA = "0x25DF9A0", Offset = "0x25DE5A0", VA = "0x1825DF9A0")]
		public void Load(string actId, string missionId)
		{
		}

		// Token: 0x0602A431 RID: 173105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A431")]
		[Address(RVA = "0x25DFC20", Offset = "0x25DE820", VA = "0x1825DFC20")]
		public Act25sideMissionViewModel()
		{
		}

		// Token: 0x0403CC15 RID: 248853
		[Token(Token = "0x403CC15")]
		[FieldOffset(Offset = "0x10")]
		private string m_missionId;

		// Token: 0x0403CC16 RID: 248854
		[Token(Token = "0x403CC16")]
		[FieldOffset(Offset = "0x18")]
		private string m_areaId;

		// Token: 0x0403CC17 RID: 248855
		[Token(Token = "0x403CC17")]
		[FieldOffset(Offset = "0x20")]
		private string m_bindStageId;

		// Token: 0x0403CC18 RID: 248856
		[Token(Token = "0x403CC18")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isZone;

		// Token: 0x0403CC19 RID: 248857
		[Token(Token = "0x403CC19")]
		[FieldOffset(Offset = "0x2C")]
		private int m_costCount;

		// Token: 0x0403CC1A RID: 248858
		[Token(Token = "0x403CC1A")]
		[FieldOffset(Offset = "0x30")]
		private int m_transform;

		// Token: 0x0403CC1B RID: 248859
		[Token(Token = "0x403CC1B")]
		[FieldOffset(Offset = "0x34")]
		private int m_progress;

		// Token: 0x0403CC1C RID: 248860
		[Token(Token = "0x403CC1C")]
		[FieldOffset(Offset = "0x38")]
		private string m_progressPicId;

		// Token: 0x0403CC1D RID: 248861
		[Token(Token = "0x403CC1D")]
		[FieldOffset(Offset = "0x40")]
		private string m_desc;

		// Token: 0x0403CC1E RID: 248862
		[Token(Token = "0x403CC1E")]
		[FieldOffset(Offset = "0x48")]
		private List<UIItemViewModel> m_rewards;

		// Token: 0x0403CC1F RID: 248863
		[Token(Token = "0x403CC1F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_missionId;

		// Token: 0x0403CC20 RID: 248864
		[Token(Token = "0x403CC20")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_areaId;

		// Token: 0x0403CC21 RID: 248865
		[Token(Token = "0x403CC21")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_bindStageId;

		// Token: 0x0403CC22 RID: 248866
		[Token(Token = "0x403CC22")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isZone;

		// Token: 0x0403CC23 RID: 248867
		[Token(Token = "0x403CC23")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_costCount;

		// Token: 0x0403CC24 RID: 248868
		[Token(Token = "0x403CC24")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_transform;

		// Token: 0x0403CC25 RID: 248869
		[Token(Token = "0x403CC25")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_progress;

		// Token: 0x0403CC26 RID: 248870
		[Token(Token = "0x403CC26")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_progressPicId;

		// Token: 0x0403CC27 RID: 248871
		[Token(Token = "0x403CC27")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x0403CC28 RID: 248872
		[Token(Token = "0x403CC28")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_rewards;

		// Token: 0x0403CC29 RID: 248873
		[Token(Token = "0x403CC29")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0403CC2A RID: 248874
		[Token(Token = "0x403CC2A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
