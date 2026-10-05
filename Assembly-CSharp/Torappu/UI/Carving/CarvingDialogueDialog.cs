using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006017 RID: 24599
	[Token(Token = "0x2006017")]
	public class CarvingDialogueDialog : UICompDialog<CarvingDialogueDialog.Options>, IHotfixable
	{
		// Token: 0x17005408 RID: 21512
		// (get) Token: 0x06023945 RID: 145733 RVA: 0x000C1488 File Offset: 0x000BF688
		[Token(Token = "0x17005408")]
		private int dialogueCount
		{
			[Token(Token = "0x6023945")]
			[Address(RVA = "0x1E38B10", Offset = "0x1E37710", VA = "0x181E38B10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005409 RID: 21513
		// (get) Token: 0x06023946 RID: 145734 RVA: 0x000C14A0 File Offset: 0x000BF6A0
		[Token(Token = "0x17005409")]
		private bool isPlayingComplete
		{
			[Token(Token = "0x6023946")]
			[Address(RVA = "0x1E38B90", Offset = "0x1E37790", VA = "0x181E38B90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06023947 RID: 145735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023947")]
		[Address(RVA = "0x1E380A0", Offset = "0x1E36CA0", VA = "0x181E380A0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06023948 RID: 145736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023948")]
		[Address(RVA = "0x1E38290", Offset = "0x1E36E90", VA = "0x181E38290", Slot = "18")]
		protected override void OnRender(CarvingDialogueDialog.Options input)
		{
		}

		// Token: 0x06023949 RID: 145737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023949")]
		[Address(RVA = "0x1E37E60", Offset = "0x1E36A60", VA = "0x181E37E60", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602394A RID: 145738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602394A")]
		[Address(RVA = "0x1E37D70", Offset = "0x1E36970", VA = "0x181E37D70", Slot = "14")]
		public override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x0602394B RID: 145739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602394B")]
		[Address(RVA = "0x1E37FF0", Offset = "0x1E36BF0", VA = "0x181E37FF0", Slot = "11")]
		protected override void OnDestroySubClass()
		{
		}

		// Token: 0x0602394C RID: 145740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602394C")]
		[Address(RVA = "0x1E37EC0", Offset = "0x1E36AC0", VA = "0x181E37EC0")]
		public void OnClick()
		{
		}

		// Token: 0x0602394D RID: 145741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602394D")]
		[Address(RVA = "0x1E38810", Offset = "0x1E37410", VA = "0x181E38810")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602394E RID: 145742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602394E")]
		[Address(RVA = "0x1E38880", Offset = "0x1E37480", VA = "0x181E38880")]
		private void _PlayNextDialogue()
		{
		}

		// Token: 0x0602394F RID: 145743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602394F")]
		[Address(RVA = "0x1E386C0", Offset = "0x1E372C0", VA = "0x181E386C0")]
		private void _ConfirmAndClose()
		{
		}

		// Token: 0x06023950 RID: 145744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023950")]
		[Address(RVA = "0x1E38AA0", Offset = "0x1E376A0", VA = "0x181E38AA0")]
		public CarvingDialogueDialog()
		{
		}

		// Token: 0x06023951 RID: 145745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023951")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06023952 RID: 145746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023952")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06023953 RID: 145747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023953")]
		[Address(RVA = "0xE0F010", Offset = "0xE0DC10", VA = "0x180E0F010")]
		private UISwitchTween <>xLuaBaseProxy_GenerateShowTween()
		{
			return null;
		}

		// Token: 0x06023954 RID: 145748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023954")]
		[Address(RVA = "0x1E376C0", Offset = "0x1E362C0", VA = "0x181E376C0")]
		private void <>xLuaBaseProxy_OnDestroySubClass()
		{
		}

		// Token: 0x040313DA RID: 201690
		[Token(Token = "0x40313DA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelBlur;

		// Token: 0x040313DB RID: 201691
		[Token(Token = "0x40313DB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIRenderTextureImage _blurBackground;

		// Token: 0x040313DC RID: 201692
		[Token(Token = "0x40313DC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CarvingDialogueDialog.NameBgConfig[] _nameBgConfig;

		// Token: 0x040313DD RID: 201693
		[Token(Token = "0x40313DD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _imgCharAvatar;

		// Token: 0x040313DE RID: 201694
		[Token(Token = "0x40313DE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textName;

		// Token: 0x040313DF RID: 201695
		[Token(Token = "0x40313DF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AVGTypeWriterText _textContent;

		// Token: 0x040313E0 RID: 201696
		[Token(Token = "0x40313E0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040313E1 RID: 201697
		[Token(Token = "0x40313E1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x040313E2 RID: 201698
		[Token(Token = "0x40313E2")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIAnimationLocation _loopAnim;

		// Token: 0x040313E3 RID: 201699
		[Token(Token = "0x40313E3")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x040313E4 RID: 201700
		[Token(Token = "0x40313E4")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_hasInited;

		// Token: 0x040313E5 RID: 201701
		[Token(Token = "0x40313E5")]
		[FieldOffset(Offset = "0xD8")]
		private Act35SideData.Act35SideDialogueGroupData m_dialogueGroupData;

		// Token: 0x040313E6 RID: 201702
		[Token(Token = "0x40313E6")]
		[FieldOffset(Offset = "0xE0")]
		private string m_cachedActId;

		// Token: 0x040313E7 RID: 201703
		[Token(Token = "0x40313E7")]
		[FieldOffset(Offset = "0xE8")]
		private int m_cachedCurrIndex;

		// Token: 0x040313E8 RID: 201704
		[Token(Token = "0x40313E8")]
		[FieldOffset(Offset = "0xF0")]
		private Tween m_loopAnim;

		// Token: 0x040313E9 RID: 201705
		[Token(Token = "0x40313E9")]
		[FieldOffset(Offset = "0xF8")]
		private string m_cachedParam;

		// Token: 0x040313EA RID: 201706
		[Token(Token = "0x40313EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dialogueCount;

		// Token: 0x040313EB RID: 201707
		[Token(Token = "0x40313EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isPlayingComplete;

		// Token: 0x040313EC RID: 201708
		[Token(Token = "0x40313EC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040313ED RID: 201709
		[Token(Token = "0x40313ED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040313EE RID: 201710
		[Token(Token = "0x40313EE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x040313EF RID: 201711
		[Token(Token = "0x40313EF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x040313F0 RID: 201712
		[Token(Token = "0x40313F0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroySubClass;

		// Token: 0x040313F1 RID: 201713
		[Token(Token = "0x40313F1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040313F2 RID: 201714
		[Token(Token = "0x40313F2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040313F3 RID: 201715
		[Token(Token = "0x40313F3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PlayNextDialogue;

		// Token: 0x040313F4 RID: 201716
		[Token(Token = "0x40313F4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ConfirmAndClose;

		// Token: 0x040313F5 RID: 201717
		[Token(Token = "0x40313F5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006018 RID: 24600
		[Token(Token = "0x2006018")]
		public class Options
		{
			// Token: 0x06023955 RID: 145749 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023955")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x040313F6 RID: 201718
			[Token(Token = "0x40313F6")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x040313F7 RID: 201719
			[Token(Token = "0x40313F7")]
			[FieldOffset(Offset = "0x18")]
			public Act35SideData.DialogueType dialogueType;

			// Token: 0x040313F8 RID: 201720
			[Token(Token = "0x40313F8")]
			[FieldOffset(Offset = "0x1C")]
			public bool showBlurImg;

			// Token: 0x040313F9 RID: 201721
			[Token(Token = "0x40313F9")]
			[FieldOffset(Offset = "0x20")]
			public string param;
		}

		// Token: 0x02006019 RID: 24601
		[Token(Token = "0x2006019")]
		[Serializable]
		private struct NameBgConfig
		{
			// Token: 0x040313FA RID: 201722
			[Token(Token = "0x40313FA")]
			[FieldOffset(Offset = "0x0")]
			public Act35SideData.DialogueNameBgType bgType;

			// Token: 0x040313FB RID: 201723
			[Token(Token = "0x40313FB")]
			[FieldOffset(Offset = "0x8")]
			public GameObject bgGameObject;
		}

		// Token: 0x0200601A RID: 24602
		[Token(Token = "0x200601A")]
		private class DialogueDialogSwitchTween : UISwitchTween, IHotfixable
		{
			// Token: 0x06023956 RID: 145750 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023956")]
			[Address(RVA = "0x1E3DE50", Offset = "0x1E3CA50", VA = "0x181E3DE50")]
			public DialogueDialogSwitchTween(CarvingDialogueDialog closure)
			{
			}

			// Token: 0x06023957 RID: 145751 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023957")]
			[Address(RVA = "0x1E3DAB0", Offset = "0x1E3C6B0", VA = "0x181E3DAB0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06023958 RID: 145752 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023958")]
			[Address(RVA = "0x1E3DBC0", Offset = "0x1E3C7C0", VA = "0x181E3DBC0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06023959 RID: 145753 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023959")]
			[Address(RVA = "0x1E3DD30", Offset = "0x1E3C930", VA = "0x181E3DD30", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602395A RID: 145754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602395A")]
			[Address(RVA = "0x1E3D9E0", Offset = "0x1E3C5E0", VA = "0x181E3D9E0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0602395B RID: 145755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602395B")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0602395C RID: 145756 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602395C")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x040313FC RID: 201724
			[Token(Token = "0x40313FC")]
			[FieldOffset(Offset = "0x48")]
			private CarvingDialogueDialog m_closure;

			// Token: 0x040313FD RID: 201725
			[Token(Token = "0x40313FD")]
			[FieldOffset(Offset = "0x50")]
			private float m_duration;

			// Token: 0x040313FE RID: 201726
			[Token(Token = "0x40313FE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040313FF RID: 201727
			[Token(Token = "0x40313FF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04031400 RID: 201728
			[Token(Token = "0x4031400")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04031401 RID: 201729
			[Token(Token = "0x4031401")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x04031402 RID: 201730
			[Token(Token = "0x4031402")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;
		}
	}
}
