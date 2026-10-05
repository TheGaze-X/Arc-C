using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AB9 RID: 27321
	[Token(Token = "0x2006AB9")]
	public abstract class ActArchiveProxy : IHotfixable
	{
		// Token: 0x17005C56 RID: 23638
		// (get) Token: 0x06027141 RID: 160065 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027142 RID: 160066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C56")]
		public RectTransform compHolder
		{
			[Token(Token = "0x6027141")]
			[Address(RVA = "0x2235040", Offset = "0x2233C40", VA = "0x182235040")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6027142")]
			[Address(RVA = "0x22351E0", Offset = "0x2233DE0", VA = "0x1822351E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005C57 RID: 23639
		// (get) Token: 0x06027143 RID: 160067 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027144 RID: 160068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C57")]
		public RectTransform topHolder
		{
			[Token(Token = "0x6027143")]
			[Address(RVA = "0x2235100", Offset = "0x2233D00", VA = "0x182235100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6027144")]
			[Address(RVA = "0x22352E0", Offset = "0x2233EE0", VA = "0x1822352E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005C58 RID: 23640
		// (get) Token: 0x06027145 RID: 160069 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027146 RID: 160070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C58")]
		public ActArchiveInfo archiveInfo
		{
			[Token(Token = "0x6027145")]
			[Address(RVA = "0x2234FE0", Offset = "0x2233BE0", VA = "0x182234FE0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6027146")]
			[Address(RVA = "0x2235160", Offset = "0x2233D60", VA = "0x182235160")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005C59 RID: 23641
		// (get) Token: 0x06027147 RID: 160071 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027148 RID: 160072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C59")]
		public State state
		{
			[Token(Token = "0x6027147")]
			[Address(RVA = "0x22350A0", Offset = "0x2233CA0", VA = "0x1822350A0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6027148")]
			[Address(RVA = "0x2235260", Offset = "0x2233E60", VA = "0x182235260")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005C5A RID: 23642
		// (get) Token: 0x06027149 RID: 160073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C5A")]
		public string archiveId
		{
			[Token(Token = "0x6027149")]
			[Address(RVA = "0x2234F20", Offset = "0x2233B20", VA = "0x182234F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602714A RID: 160074
		[Token(Token = "0x602714A")]
		public abstract void OnEnter();

		// Token: 0x0602714B RID: 160075
		[Token(Token = "0x602714B")]
		public abstract void OnExit();

		// Token: 0x0602714C RID: 160076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602714C")]
		[Address(RVA = "0x2234E10", Offset = "0x2233A10", VA = "0x182234E10", Slot = "6")]
		public virtual IEnumerator Show(bool fastMode)
		{
			return null;
		}

		// Token: 0x0602714D RID: 160077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602714D")]
		[Address(RVA = "0x2234B40", Offset = "0x2233740", VA = "0x182234B40", Slot = "7")]
		public virtual void BeforePageExit()
		{
		}

		// Token: 0x0602714E RID: 160078 RVA: 0x000CD6E0 File Offset: 0x000CB8E0
		[Token(Token = "0x602714E")]
		public bool LoadAsset<T>(string assetPath, out T asset) where T : UnityEngine.Object
		{
			return default(bool);
		}

		// Token: 0x0602714F RID: 160079 RVA: 0x000CD6F8 File Offset: 0x000CB8F8
		[Token(Token = "0x602714F")]
		[Address(RVA = "0x2234C70", Offset = "0x2233870", VA = "0x182234C70")]
		public bool LoadSpriteFromAutoPackHub(string spriteId, string hubPath, out Sprite sprite)
		{
			return default(bool);
		}

		// Token: 0x06027150 RID: 160080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027150")]
		[Address(RVA = "0x2234BA0", Offset = "0x22337A0", VA = "0x182234BA0")]
		public void CoroutineWithPage(IEnumerator routine)
		{
		}

		// Token: 0x06027151 RID: 160081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027151")]
		[Address(RVA = "0x2234EC0", Offset = "0x2233AC0", VA = "0x182234EC0")]
		protected ActArchiveProxy()
		{
		}

		// Token: 0x040374B7 RID: 226487
		[Token(Token = "0x40374B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compHolder;

		// Token: 0x040374B8 RID: 226488
		[Token(Token = "0x40374B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_compHolder;

		// Token: 0x040374B9 RID: 226489
		[Token(Token = "0x40374B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_topHolder;

		// Token: 0x040374BA RID: 226490
		[Token(Token = "0x40374BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_topHolder;

		// Token: 0x040374BB RID: 226491
		[Token(Token = "0x40374BB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_archiveInfo;

		// Token: 0x040374BC RID: 226492
		[Token(Token = "0x40374BC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_archiveInfo;

		// Token: 0x040374BD RID: 226493
		[Token(Token = "0x40374BD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x040374BE RID: 226494
		[Token(Token = "0x40374BE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x040374BF RID: 226495
		[Token(Token = "0x40374BF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_archiveId;

		// Token: 0x040374C0 RID: 226496
		[Token(Token = "0x40374C0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040374C1 RID: 226497
		[Token(Token = "0x40374C1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_BeforePageExit;

		// Token: 0x040374C2 RID: 226498
		[Token(Token = "0x40374C2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x040374C3 RID: 226499
		[Token(Token = "0x40374C3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadSpriteFromAutoPackHub;

		// Token: 0x040374C4 RID: 226500
		[Token(Token = "0x40374C4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CoroutineWithPage;

		// Token: 0x040374C5 RID: 226501
		[Token(Token = "0x40374C5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
