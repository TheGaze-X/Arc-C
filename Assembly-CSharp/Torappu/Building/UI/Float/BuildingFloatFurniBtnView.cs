using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Building.Vault;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DF1 RID: 7665
	[Token(Token = "0x2001DF1")]
	public class BuildingFloatFurniBtnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600BD4F RID: 48463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD4F")]
		[Address(RVA = "0x339F1C0", Offset = "0x339DDC0", VA = "0x18339F1C0")]
		public void OnFurniBtnViewInit(RoomSlotModel roomModel)
		{
		}

		// Token: 0x0600BD50 RID: 48464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD50")]
		[Address(RVA = "0x339F020", Offset = "0x339DC20", VA = "0x18339F020")]
		public void OnFurniBtnViewEnable(RoomSlotModel roomModel)
		{
		}

		// Token: 0x0600BD51 RID: 48465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD51")]
		[Address(RVA = "0x339EF80", Offset = "0x339DB80", VA = "0x18339EF80")]
		public void OnFurniBtnViewDisable()
		{
		}

		// Token: 0x0600BD52 RID: 48466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD52")]
		[Address(RVA = "0x339F120", Offset = "0x339DD20", VA = "0x18339F120")]
		public void OnFurniBtnViewExit()
		{
		}

		// Token: 0x0600BD53 RID: 48467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD53")]
		[Address(RVA = "0x339F2C0", Offset = "0x339DEC0", VA = "0x18339F2C0")]
		public void OnStateUpdated(RoomSlotModel roomModel)
		{
		}

		// Token: 0x0600BD54 RID: 48468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD54")]
		[Address(RVA = "0x339ED50", Offset = "0x339D950", VA = "0x18339ED50")]
		public void OnFurniBtnClick(RoomSlotModel roomModel)
		{
		}

		// Token: 0x0600BD55 RID: 48469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BD55")]
		[Address(RVA = "0x339F3C0", Offset = "0x339DFC0", VA = "0x18339F3C0")]
		private IEnumerator _DisableButton(VDIYRoom room)
		{
			return null;
		}

		// Token: 0x0600BD56 RID: 48470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD56")]
		[Address(RVA = "0x339F490", Offset = "0x339E090", VA = "0x18339F490")]
		public BuildingFloatFurniBtnView()
		{
		}

		// Token: 0x0400BD8E RID: 48526
		[Token(Token = "0x400BD8E")]
		private const string HIGHLIGHT_BUTTON_ANIM_START = "btn_active_furni_start";

		// Token: 0x0400BD8F RID: 48527
		[Token(Token = "0x400BD8F")]
		private const string HIGHLIGHT_BUTTON_ANIM_END = "btn_active_furni_end";

		// Token: 0x0400BD90 RID: 48528
		[Token(Token = "0x400BD90")]
		private const string HIGHLIGHT_BUTTON_ANIM_RESET = "btn_active_furni_reset";

		// Token: 0x0400BD91 RID: 48529
		[Token(Token = "0x400BD91")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400BD92 RID: 48530
		[Token(Token = "0x400BD92")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _highlightButtonObject;

		// Token: 0x0400BD93 RID: 48531
		[Token(Token = "0x400BD93")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationWrapper _highlightBtnAnimWrapper;

		// Token: 0x0400BD94 RID: 48532
		[Token(Token = "0x400BD94")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine m_interactCoroutine;

		// Token: 0x0400BD95 RID: 48533
		[Token(Token = "0x400BD95")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnFurniBtnViewInit;

		// Token: 0x0400BD96 RID: 48534
		[Token(Token = "0x400BD96")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFurniBtnViewEnable;

		// Token: 0x0400BD97 RID: 48535
		[Token(Token = "0x400BD97")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFurniBtnViewDisable;

		// Token: 0x0400BD98 RID: 48536
		[Token(Token = "0x400BD98")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFurniBtnViewExit;

		// Token: 0x0400BD99 RID: 48537
		[Token(Token = "0x400BD99")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BD9A RID: 48538
		[Token(Token = "0x400BD9A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnFurniBtnClick;

		// Token: 0x0400BD9B RID: 48539
		[Token(Token = "0x400BD9B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DisableButton;

		// Token: 0x0400BD9C RID: 48540
		[Token(Token = "0x400BD9C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
