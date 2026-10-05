using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071BD RID: 29117
	[Token(Token = "0x20071BD")]
	public class Act6FunZoneMapAchieveInfoPlugin : ActivityCustomZoneMapBasePlugin
	{
		// Token: 0x170061DB RID: 25051
		// (get) Token: 0x06029523 RID: 169251 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06029524 RID: 169252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061DB")]
		public Action<string> onClaimReward
		{
			[Token(Token = "0x6029523")]
			[Address(RVA = "0x24B0300", Offset = "0x24AEF00", VA = "0x1824B0300")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6029524")]
			[Address(RVA = "0x24B0360", Offset = "0x24AEF60", VA = "0x1824B0360")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06029525 RID: 169253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029525")]
		[Address(RVA = "0x24AFE40", Offset = "0x24AEA40", VA = "0x1824AFE40", Slot = "5")]
		public override void Render(ActivityCustomZoneMapViewModel model, bool isFastMode)
		{
		}

		// Token: 0x06029526 RID: 169254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029526")]
		[Address(RVA = "0x24B0190", Offset = "0x24AED90", VA = "0x1824B0190")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029527 RID: 169255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029527")]
		[Address(RVA = "0x24B0290", Offset = "0x24AEE90", VA = "0x1824B0290")]
		public Act6FunZoneMapAchieveInfoPlugin()
		{
		}

		// Token: 0x06029528 RID: 169256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029528")]
		[Address(RVA = "0x24B0180", Offset = "0x24AED80", VA = "0x1824B0180")]
		private void <>xLuaBaseProxy_Render(ActivityCustomZoneMapViewModel P0, bool P1)
		{
		}

		// Token: 0x0403B01F RID: 241695
		[Token(Token = "0x403B01F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act6FunZoneMapAchieveView _achieveView;

		// Token: 0x0403B020 RID: 241696
		[Token(Token = "0x403B020")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x0403B021 RID: 241697
		[Token(Token = "0x403B021")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0403B023 RID: 241699
		[Token(Token = "0x403B023")]
		[FieldOffset(Offset = "0x38")]
		private UISwitchTween m_switchTween;

		// Token: 0x0403B024 RID: 241700
		[Token(Token = "0x403B024")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0403B025 RID: 241701
		[Token(Token = "0x403B025")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClaimReward;

		// Token: 0x0403B026 RID: 241702
		[Token(Token = "0x403B026")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClaimReward;

		// Token: 0x0403B027 RID: 241703
		[Token(Token = "0x403B027")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B028 RID: 241704
		[Token(Token = "0x403B028")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B029 RID: 241705
		[Token(Token = "0x403B029")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
