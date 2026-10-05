using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DB2 RID: 15794
	[Token(Token = "0x2003DB2")]
	public class TemplateMissionRewardActivityItemViewModel : AbstractTemplateMissionRewardItemViewModel
	{
		// Token: 0x17003A9D RID: 15005
		// (get) Token: 0x060188EA RID: 100586 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060188EB RID: 100587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A9D")]
		public BasicActivityItemViewModel activityItemViewModel
		{
			[Token(Token = "0x60188EA")]
			[Address(RVA = "0x1114C80", Offset = "0x1113880", VA = "0x181114C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60188EB")]
			[Address(RVA = "0x1114DE0", Offset = "0x11139E0", VA = "0x181114DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003A9E RID: 15006
		// (get) Token: 0x060188EC RID: 100588 RVA: 0x0009ABD8 File Offset: 0x00098DD8
		[Token(Token = "0x17003A9E")]
		public bool isReplicate
		{
			[Token(Token = "0x60188EC")]
			[Address(RVA = "0x1114CE0", Offset = "0x11138E0", VA = "0x181114CE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060188ED RID: 100589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188ED")]
		[Address(RVA = "0x1114A20", Offset = "0x1113620", VA = "0x181114A20", Slot = "4")]
		public override void Init(string keyId, string itemId, int count, ItemType itemType)
		{
		}

		// Token: 0x060188EE RID: 100590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188EE")]
		[Address(RVA = "0x1114BE0", Offset = "0x11137E0", VA = "0x181114BE0")]
		public TemplateMissionRewardActivityItemViewModel()
		{
		}

		// Token: 0x0401E1C4 RID: 123332
		[Token(Token = "0x401E1C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityItemViewModel;

		// Token: 0x0401E1C5 RID: 123333
		[Token(Token = "0x401E1C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_activityItemViewModel;

		// Token: 0x0401E1C6 RID: 123334
		[Token(Token = "0x401E1C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isReplicate;

		// Token: 0x0401E1C7 RID: 123335
		[Token(Token = "0x401E1C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401E1C8 RID: 123336
		[Token(Token = "0x401E1C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
