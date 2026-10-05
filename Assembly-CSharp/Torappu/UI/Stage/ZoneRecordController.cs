using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069DC RID: 27100
	[Token(Token = "0x20069DC")]
	public abstract class ZoneRecordController : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B7D RID: 23421
		// (get) Token: 0x06026C3E RID: 158782 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026C3F RID: 158783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B7D")]
		public Action closeZoneRecordState
		{
			[Token(Token = "0x6026C3E")]
			[Address(RVA = "0x21DD1E0", Offset = "0x21DBDE0", VA = "0x1821DD1E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6026C3F")]
			[Address(RVA = "0x21DD240", Offset = "0x21DBE40", VA = "0x1821DD240")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026C40 RID: 158784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C40")]
		[Address(RVA = "0x21DCDD0", Offset = "0x21DB9D0", VA = "0x1821DCDD0", Slot = "4")]
		public virtual void Init()
		{
		}

		// Token: 0x06026C41 RID: 158785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C41")]
		[Address(RVA = "0x21DCE30", Offset = "0x21DBA30", VA = "0x1821DCE30", Slot = "5")]
		public virtual void OnEnter(string zoneId)
		{
		}

		// Token: 0x06026C42 RID: 158786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C42")]
		[Address(RVA = "0x21DCE90", Offset = "0x21DBA90", VA = "0x1821DCE90", Slot = "6")]
		public virtual void OnResume(bool isFromStack)
		{
		}

		// Token: 0x06026C43 RID: 158787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C43")]
		[Address(RVA = "0x21DD000", Offset = "0x21DBC00", VA = "0x1821DD000")]
		protected static CommonTopMenu _CreateCommonTopMenu(RectTransform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x06026C44 RID: 158788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C44")]
		[Address(RVA = "0x21DCEF0", Offset = "0x21DBAF0", VA = "0x1821DCEF0")]
		protected void _CloseZoneRecord()
		{
		}

		// Token: 0x06026C45 RID: 158789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C45")]
		[Address(RVA = "0x21DD180", Offset = "0x21DBD80", VA = "0x1821DD180")]
		protected ZoneRecordController()
		{
		}

		// Token: 0x04036C19 RID: 224281
		[Token(Token = "0x4036C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public UIPage page;

		// Token: 0x04036C1B RID: 224283
		[Token(Token = "0x4036C1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_closeZoneRecordState;

		// Token: 0x04036C1C RID: 224284
		[Token(Token = "0x4036C1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_closeZoneRecordState;

		// Token: 0x04036C1D RID: 224285
		[Token(Token = "0x4036C1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04036C1E RID: 224286
		[Token(Token = "0x4036C1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04036C1F RID: 224287
		[Token(Token = "0x4036C1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04036C20 RID: 224288
		[Token(Token = "0x4036C20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CreateCommonTopMenu;

		// Token: 0x04036C21 RID: 224289
		[Token(Token = "0x4036C21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CloseZoneRecord;

		// Token: 0x04036C22 RID: 224290
		[Token(Token = "0x4036C22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
