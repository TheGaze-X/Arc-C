using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071BE RID: 29118
	[Token(Token = "0x20071BE")]
	public class Act6FunZoneMapBgPlugin : ActivityCustomZoneMapBasePlugin
	{
		// Token: 0x170061DC RID: 25052
		// (get) Token: 0x06029529 RID: 169257 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602952A RID: 169258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061DC")]
		public Action onBgClick
		{
			[Token(Token = "0x6029529")]
			[Address(RVA = "0x24B38E0", Offset = "0x24B24E0", VA = "0x1824B38E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602952A")]
			[Address(RVA = "0x24B3940", Offset = "0x24B2540", VA = "0x1824B3940")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602952B RID: 169259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602952B")]
		[Address(RVA = "0x24B3320", Offset = "0x24B1F20", VA = "0x1824B3320", Slot = "5")]
		public override void Render(ActivityCustomZoneMapViewModel model, bool isFastMode)
		{
		}

		// Token: 0x0602952C RID: 169260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602952C")]
		[Address(RVA = "0x24B3720", Offset = "0x24B2320", VA = "0x1824B3720")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602952D RID: 169261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602952D")]
		[Address(RVA = "0x24B3880", Offset = "0x24B2480", VA = "0x1824B3880")]
		public Act6FunZoneMapBgPlugin()
		{
		}

		// Token: 0x0602952F RID: 169263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602952F")]
		[Address(RVA = "0x24B0180", Offset = "0x24AED80", VA = "0x1824B0180")]
		private void <>xLuaBaseProxy_Render(ActivityCustomZoneMapViewModel P0, bool P1)
		{
		}

		// Token: 0x0403B02A RID: 241706
		[Token(Token = "0x403B02A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objNormalBg;

		// Token: 0x0403B02B RID: 241707
		[Token(Token = "0x403B02B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objBonusBg;

		// Token: 0x0403B02C RID: 241708
		[Token(Token = "0x403B02C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private EventTrigger _bgEventTrigger;

		// Token: 0x0403B02D RID: 241709
		[Token(Token = "0x403B02D")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0403B02F RID: 241711
		[Token(Token = "0x403B02F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBgClick;

		// Token: 0x0403B030 RID: 241712
		[Token(Token = "0x403B030")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBgClick;

		// Token: 0x0403B031 RID: 241713
		[Token(Token = "0x403B031")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B032 RID: 241714
		[Token(Token = "0x403B032")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B033 RID: 241715
		[Token(Token = "0x403B033")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
