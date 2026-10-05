using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200517B RID: 20859
	[Token(Token = "0x200517B")]
	public class DeepSeaRPTechTreeNodeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170047CE RID: 18382
		// (get) Token: 0x0601ED27 RID: 126247 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ED28 RID: 126248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047CE")]
		public Action<string> onUnsetClicked
		{
			[Token(Token = "0x601ED27")]
			[Address(RVA = "0x1899640", Offset = "0x1898240", VA = "0x181899640")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601ED28")]
			[Address(RVA = "0x1899820", Offset = "0x1898420", VA = "0x181899820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170047CF RID: 18383
		// (get) Token: 0x0601ED29 RID: 126249 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ED2A RID: 126250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047CF")]
		public Action<string> onActiveClicked
		{
			[Token(Token = "0x601ED29")]
			[Address(RVA = "0x1899520", Offset = "0x1898120", VA = "0x181899520")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601ED2A")]
			[Address(RVA = "0x18996A0", Offset = "0x18982A0", VA = "0x1818996A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170047D0 RID: 18384
		// (get) Token: 0x0601ED2B RID: 126251 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ED2C RID: 126252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047D0")]
		public Action<string> onSetClicked
		{
			[Token(Token = "0x601ED2B")]
			[Address(RVA = "0x18995E0", Offset = "0x18981E0", VA = "0x1818995E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601ED2C")]
			[Address(RVA = "0x18997A0", Offset = "0x18983A0", VA = "0x1818997A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170047D1 RID: 18385
		// (get) Token: 0x0601ED2D RID: 126253 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ED2E RID: 126254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047D1")]
		public Action<string> onNodeToggleClicked
		{
			[Token(Token = "0x601ED2D")]
			[Address(RVA = "0x1899580", Offset = "0x1898180", VA = "0x181899580")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601ED2E")]
			[Address(RVA = "0x1899720", Offset = "0x1898320", VA = "0x181899720")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601ED2F RID: 126255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED2F")]
		[Address(RVA = "0x1898E40", Offset = "0x1897A40", VA = "0x181898E40")]
		public void Render(DeepSeaRPTechTreeNodeModel model)
		{
		}

		// Token: 0x0601ED30 RID: 126256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED30")]
		[Address(RVA = "0x1899280", Offset = "0x1897E80", VA = "0x181899280")]
		private void _InitIfNot(bool togglePlay)
		{
		}

		// Token: 0x0601ED31 RID: 126257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED31")]
		[Address(RVA = "0x1898D30", Offset = "0x1897930", VA = "0x181898D30")]
		public void EventOnUnsetClick()
		{
		}

		// Token: 0x0601ED32 RID: 126258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED32")]
		[Address(RVA = "0x18989D0", Offset = "0x18975D0", VA = "0x1818989D0")]
		public void EventOnActiveClick()
		{
		}

		// Token: 0x0601ED33 RID: 126259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED33")]
		[Address(RVA = "0x1898C10", Offset = "0x1897810", VA = "0x181898C10")]
		public void EventOnSetClick()
		{
		}

		// Token: 0x0601ED34 RID: 126260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED34")]
		[Address(RVA = "0x1898AF0", Offset = "0x18976F0", VA = "0x181898AF0")]
		public void EventOnNodeToggleClick()
		{
		}

		// Token: 0x0601ED35 RID: 126261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED35")]
		[Address(RVA = "0x18994C0", Offset = "0x18980C0", VA = "0x1818994C0")]
		public DeepSeaRPTechTreeNodeView()
		{
		}

		// Token: 0x04029566 RID: 169318
		[Token(Token = "0x4029566")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objNormPart;

		// Token: 0x04029567 RID: 169319
		[Token(Token = "0x4029567")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtTitleNorm;

		// Token: 0x04029568 RID: 169320
		[Token(Token = "0x4029568")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtDesc;

		// Token: 0x04029569 RID: 169321
		[Token(Token = "0x4029569")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _toggleAnim;

		// Token: 0x0402956A RID: 169322
		[Token(Token = "0x402956A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtNode1Name;

		// Token: 0x0402956B RID: 169323
		[Token(Token = "0x402956B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtNode2Name;

		// Token: 0x0402956C RID: 169324
		[Token(Token = "0x402956C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objActivePart;

		// Token: 0x0402956D RID: 169325
		[Token(Token = "0x402956D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _txtTitleActive;

		// Token: 0x0402956E RID: 169326
		[Token(Token = "0x402956E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objSetPart;

		// Token: 0x0402956F RID: 169327
		[Token(Token = "0x402956F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _txtTitleSet;

		// Token: 0x04029570 RID: 169328
		[Token(Token = "0x4029570")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objLockedPart;

		// Token: 0x04029571 RID: 169329
		[Token(Token = "0x4029571")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _txtLockInfo;

		// Token: 0x04029572 RID: 169330
		[Token(Token = "0x4029572")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _objLineUnlock;

		// Token: 0x04029573 RID: 169331
		[Token(Token = "0x4029573")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _objLineLocked;

		// Token: 0x04029574 RID: 169332
		[Token(Token = "0x4029574")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup _canvasTreeOn;

		// Token: 0x04029575 RID: 169333
		[Token(Token = "0x4029575")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _canvasTreeSet;

		// Token: 0x04029576 RID: 169334
		[Token(Token = "0x4029576")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _objTreeOn1;

		// Token: 0x04029577 RID: 169335
		[Token(Token = "0x4029577")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _objTreeOn2;

		// Token: 0x04029578 RID: 169336
		[Token(Token = "0x4029578")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _objTreeSet;

		// Token: 0x04029579 RID: 169337
		[Token(Token = "0x4029579")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _objTreeActive;

		// Token: 0x0402957A RID: 169338
		[Token(Token = "0x402957A")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _objTreeLocked;

		// Token: 0x0402957B RID: 169339
		[Token(Token = "0x402957B")]
		[FieldOffset(Offset = "0xC8")]
		private AnimationSwitchTween m_toggleSwitch;

		// Token: 0x04029580 RID: 169344
		[Token(Token = "0x4029580")]
		[FieldOffset(Offset = "0xF0")]
		private string m_techId;

		// Token: 0x04029581 RID: 169345
		[Token(Token = "0x4029581")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_hasInited;

		// Token: 0x04029582 RID: 169346
		[Token(Token = "0x4029582")]
		[FieldOffset(Offset = "0x100")]
		private FadeSwitchTween m_tweenTreeOn;

		// Token: 0x04029583 RID: 169347
		[Token(Token = "0x4029583")]
		[FieldOffset(Offset = "0x108")]
		private FadeSwitchTween m_tweenTreeSet;

		// Token: 0x04029584 RID: 169348
		[Token(Token = "0x4029584")]
		private const float TREE_TWEEN_DUR = 0.2f;

		// Token: 0x04029585 RID: 169349
		[Token(Token = "0x4029585")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onUnsetClicked;

		// Token: 0x04029586 RID: 169350
		[Token(Token = "0x4029586")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onUnsetClicked;

		// Token: 0x04029587 RID: 169351
		[Token(Token = "0x4029587")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onActiveClicked;

		// Token: 0x04029588 RID: 169352
		[Token(Token = "0x4029588")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onActiveClicked;

		// Token: 0x04029589 RID: 169353
		[Token(Token = "0x4029589")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onSetClicked;

		// Token: 0x0402958A RID: 169354
		[Token(Token = "0x402958A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onSetClicked;

		// Token: 0x0402958B RID: 169355
		[Token(Token = "0x402958B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onNodeToggleClicked;

		// Token: 0x0402958C RID: 169356
		[Token(Token = "0x402958C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onNodeToggleClicked;

		// Token: 0x0402958D RID: 169357
		[Token(Token = "0x402958D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402958E RID: 169358
		[Token(Token = "0x402958E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402958F RID: 169359
		[Token(Token = "0x402958F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnUnsetClick;

		// Token: 0x04029590 RID: 169360
		[Token(Token = "0x4029590")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnActiveClick;

		// Token: 0x04029591 RID: 169361
		[Token(Token = "0x4029591")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnSetClick;

		// Token: 0x04029592 RID: 169362
		[Token(Token = "0x4029592")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnNodeToggleClick;

		// Token: 0x04029593 RID: 169363
		[Token(Token = "0x4029593")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
