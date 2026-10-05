using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BB8 RID: 15288
	[Token(Token = "0x2003BB8")]
	public class VoicelangPowerItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017F14 RID: 98068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F14")]
		[Address(RVA = "0x106ECF0", Offset = "0x106D8F0", VA = "0x18106ECF0")]
		public void SetPower(VoicelangPowerViewModel powerData)
		{
		}

		// Token: 0x06017F15 RID: 98069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F15")]
		[Address(RVA = "0x106EE80", Offset = "0x106DA80", VA = "0x18106EE80")]
		public void SetSelected(bool selected)
		{
		}

		// Token: 0x06017F16 RID: 98070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F16")]
		[Address(RVA = "0x106EC70", Offset = "0x106D870", VA = "0x18106EC70")]
		public void SetEvent(UISelectPowerEvent onClick)
		{
		}

		// Token: 0x06017F17 RID: 98071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F17")]
		[Address(RVA = "0x106EBE0", Offset = "0x106D7E0", VA = "0x18106EBE0")]
		public void OnButtonClick()
		{
		}

		// Token: 0x06017F18 RID: 98072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F18")]
		[Address(RVA = "0x106EFE0", Offset = "0x106DBE0", VA = "0x18106EFE0")]
		public VoicelangPowerItemView()
		{
		}

		// Token: 0x0401CF4F RID: 118607
		[Token(Token = "0x401CF4F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_selected_Height;

		// Token: 0x0401CF50 RID: 118608
		[Token(Token = "0x401CF50")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_unSelected_Height;

		// Token: 0x0401CF51 RID: 118609
		[Token(Token = "0x401CF51")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_lbPowerName;

		// Token: 0x0401CF52 RID: 118610
		[Token(Token = "0x401CF52")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_lbPowerCode;

		// Token: 0x0401CF53 RID: 118611
		[Token(Token = "0x401CF53")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image m_imgSelectedLogo;

		// Token: 0x0401CF54 RID: 118612
		[Token(Token = "0x401CF54")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image m_imgUnselectedLogo;

		// Token: 0x0401CF55 RID: 118613
		[Token(Token = "0x401CF55")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject m_go_Selected;

		// Token: 0x0401CF56 RID: 118614
		[Token(Token = "0x401CF56")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject m_go_unSelected;

		// Token: 0x0401CF57 RID: 118615
		[Token(Token = "0x401CF57")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform rectTrans;

		// Token: 0x0401CF58 RID: 118616
		[Token(Token = "0x401CF58")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Sprite m_powerAllSprite;

		// Token: 0x0401CF59 RID: 118617
		[Token(Token = "0x401CF59")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject m_go_New;

		// Token: 0x0401CF5A RID: 118618
		[Token(Token = "0x401CF5A")]
		[FieldOffset(Offset = "0x68")]
		private bool m_selected;

		// Token: 0x0401CF5B RID: 118619
		[Token(Token = "0x401CF5B")]
		[FieldOffset(Offset = "0x70")]
		private VoicelangPowerViewModel m_powerData;

		// Token: 0x0401CF5C RID: 118620
		[Token(Token = "0x401CF5C")]
		[FieldOffset(Offset = "0x78")]
		private UISelectPowerEvent m_onClick;

		// Token: 0x0401CF5D RID: 118621
		[Token(Token = "0x401CF5D")]
		[FieldOffset(Offset = "0x80")]
		private int[] m_fontSizes;

		// Token: 0x0401CF5E RID: 118622
		[Token(Token = "0x401CF5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetPower;

		// Token: 0x0401CF5F RID: 118623
		[Token(Token = "0x401CF5F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelected;

		// Token: 0x0401CF60 RID: 118624
		[Token(Token = "0x401CF60")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetEvent;

		// Token: 0x0401CF61 RID: 118625
		[Token(Token = "0x401CF61")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnButtonClick;

		// Token: 0x0401CF62 RID: 118626
		[Token(Token = "0x401CF62")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BB9 RID: 15289
		[Token(Token = "0x2003BB9")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<VoicelangPowerItemView>
		{
			// Token: 0x06017F19 RID: 98073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F19")]
			[Address(RVA = "0x1069EF0", Offset = "0x1068AF0", VA = "0x181069EF0")]
			public VirtualView(VoicelangPowerItemView prefab)
			{
			}

			// Token: 0x06017F1A RID: 98074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F1A")]
			[Address(RVA = "0x1069BA0", Offset = "0x10687A0", VA = "0x181069BA0")]
			public void SetPower(VoicelangPowerViewModel powerData)
			{
			}

			// Token: 0x06017F1B RID: 98075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F1B")]
			[Address(RVA = "0x1069DE0", Offset = "0x10689E0", VA = "0x181069DE0")]
			public void SetSelected(bool selected)
			{
			}

			// Token: 0x06017F1C RID: 98076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F1C")]
			[Address(RVA = "0x1069CE0", Offset = "0x10688E0", VA = "0x181069CE0")]
			public void SetSelectEvent(UISelectPowerEvent _event)
			{
			}

			// Token: 0x06017F1D RID: 98077 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017F1D")]
			[Address(RVA = "0x1069990", Offset = "0x1068590", VA = "0x181069990", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06017F1E RID: 98078 RVA: 0x00098BC8 File Offset: 0x00096DC8
			[Token(Token = "0x6017F1E")]
			[Address(RVA = "0x1069A00", Offset = "0x1068600", VA = "0x181069A00", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06017F1F RID: 98079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F1F")]
			[Address(RVA = "0x1069A60", Offset = "0x1068660", VA = "0x181069A60", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06017F20 RID: 98080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F20")]
			[Address(RVA = "0x1069B40", Offset = "0x1068740", VA = "0x181069B40", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0401CF63 RID: 118627
			[Token(Token = "0x401CF63")]
			private const float TWEEN_DURATION = 0.23f;

			// Token: 0x0401CF64 RID: 118628
			[Token(Token = "0x401CF64")]
			[FieldOffset(Offset = "0x20")]
			private VoicelangPowerItemView m_prefab;

			// Token: 0x0401CF65 RID: 118629
			[Token(Token = "0x401CF65")]
			[FieldOffset(Offset = "0x28")]
			private VoicelangPowerViewModel m_powerData;

			// Token: 0x0401CF66 RID: 118630
			[Token(Token = "0x401CF66")]
			[FieldOffset(Offset = "0x30")]
			private UISelectPowerEvent m_onSelect;

			// Token: 0x0401CF67 RID: 118631
			[Token(Token = "0x401CF67")]
			[FieldOffset(Offset = "0x38")]
			private bool m_selected;

			// Token: 0x0401CF68 RID: 118632
			[Token(Token = "0x401CF68")]
			[FieldOffset(Offset = "0x3C")]
			private float m_dynamicHeight;

			// Token: 0x0401CF69 RID: 118633
			[Token(Token = "0x401CF69")]
			[FieldOffset(Offset = "0x40")]
			private bool m_lastIsNew;

			// Token: 0x0401CF6A RID: 118634
			[Token(Token = "0x401CF6A")]
			[FieldOffset(Offset = "0x48")]
			private VoicelangPowerItemView.VirtualView.SwitchTween m_tween;

			// Token: 0x0401CF6B RID: 118635
			[Token(Token = "0x401CF6B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401CF6C RID: 118636
			[Token(Token = "0x401CF6C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetPower;

			// Token: 0x0401CF6D RID: 118637
			[Token(Token = "0x401CF6D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetSelected;

			// Token: 0x0401CF6E RID: 118638
			[Token(Token = "0x401CF6E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_SetSelectEvent;

			// Token: 0x0401CF6F RID: 118639
			[Token(Token = "0x401CF6F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401CF70 RID: 118640
			[Token(Token = "0x401CF70")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0401CF71 RID: 118641
			[Token(Token = "0x401CF71")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0401CF72 RID: 118642
			[Token(Token = "0x401CF72")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x02003BBA RID: 15290
			[Token(Token = "0x2003BBA")]
			private class SwitchTween : UISwitchTween
			{
				// Token: 0x06017F21 RID: 98081 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6017F21")]
				[Address(RVA = "0x105F970", Offset = "0x105E570", VA = "0x18105F970")]
				public SwitchTween(VoicelangPowerItemView.VirtualView closure, VoicelangPowerItemView prefab)
				{
				}

				// Token: 0x06017F22 RID: 98082 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6017F22")]
				[Address(RVA = "0x105F330", Offset = "0x105DF30", VA = "0x18105F330", Slot = "5")]
				protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
				{
					return null;
				}

				// Token: 0x06017F23 RID: 98083 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6017F23")]
				[Address(RVA = "0x105F5E0", Offset = "0x105E1E0", VA = "0x18105F5E0", Slot = "4")]
				protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
				{
					return null;
				}

				// Token: 0x06017F24 RID: 98084 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6017F24")]
				[Address(RVA = "0x105F890", Offset = "0x105E490", VA = "0x18105F890", Slot = "10")]
				protected override void ResetToState(bool isShow)
				{
				}

				// Token: 0x06017F25 RID: 98085 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6017F25")]
				[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
				private void <>xLuaBaseProxy_ResetToState(bool P0)
				{
				}

				// Token: 0x0401CF73 RID: 118643
				[Token(Token = "0x401CF73")]
				[FieldOffset(Offset = "0x48")]
				private VoicelangPowerItemView.VirtualView m_closure;

				// Token: 0x0401CF74 RID: 118644
				[Token(Token = "0x401CF74")]
				[FieldOffset(Offset = "0x50")]
				private VoicelangPowerItemView m_prefab;

				// Token: 0x0401CF75 RID: 118645
				[Token(Token = "0x401CF75")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge _c__Hotfix0_ctor;

				// Token: 0x0401CF76 RID: 118646
				[Token(Token = "0x401CF76")]
				[FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

				// Token: 0x0401CF77 RID: 118647
				[Token(Token = "0x401CF77")]
				[FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

				// Token: 0x0401CF78 RID: 118648
				[Token(Token = "0x401CF78")]
				[FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_ResetToState;
			}
		}
	}
}
