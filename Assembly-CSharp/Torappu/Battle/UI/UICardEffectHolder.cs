using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032BE RID: 12990
	[Token(Token = "0x20032BE")]
	public class UICardEffectHolder : UIFollower
	{
		// Token: 0x06014A45 RID: 84549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A45")]
		[Address(RVA = "0xCE1640", Offset = "0xCE0240", VA = "0x180CE1640")]
		public void UpdateState(UICard card)
		{
		}

		// Token: 0x06014A46 RID: 84550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A46")]
		[Address(RVA = "0xCE1100", Offset = "0xCDFD00", VA = "0x180CE1100")]
		public void UpdateEffect(UICard card)
		{
		}

		// Token: 0x06014A47 RID: 84551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A47")]
		[Address(RVA = "0xCE0C70", Offset = "0xCDF870", VA = "0x180CE0C70")]
		public void ShowSelectImage(bool isShow)
		{
		}

		// Token: 0x06014A48 RID: 84552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A48")]
		[Address(RVA = "0xCE1840", Offset = "0xCE0440", VA = "0x180CE1840", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x06014A49 RID: 84553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A49")]
		[Address(RVA = "0xCE0B20", Offset = "0xCDF720", VA = "0x180CE0B20")]
		private void Awake()
		{
		}

		// Token: 0x06014A4A RID: 84554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A4A")]
		[Address(RVA = "0xCE0D00", Offset = "0xCDF900", VA = "0x180CE0D00")]
		public void UpdateCardEffectPlugin(Deck.Card card)
		{
		}

		// Token: 0x06014A4B RID: 84555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A4B")]
		[Address(RVA = "0xCE0BD0", Offset = "0xCDF7D0", VA = "0x180CE0BD0")]
		public void RemoveCardEffectPlugin(UICardEffectHolder.CardEffectPlugin plugin)
		{
		}

		// Token: 0x06014A4C RID: 84556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A4C")]
		[Address(RVA = "0xCE1920", Offset = "0xCE0520", VA = "0x180CE1920")]
		public UICardEffectHolder()
		{
		}

		// Token: 0x06014A4D RID: 84557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A4D")]
		[Address(RVA = "0xCE0CF0", Offset = "0xCDF8F0", VA = "0x180CE0CF0")]
		private void <>xLuaBaseProxy_Update()
		{
		}

		// Token: 0x0401876B RID: 100203
		[Token(Token = "0x401876B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _comboImageOutline;

		// Token: 0x0401876C RID: 100204
		[Token(Token = "0x401876C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _durangeImage;

		// Token: 0x0401876D RID: 100205
		[Token(Token = "0x401876D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _tauntImage;

		// Token: 0x0401876E RID: 100206
		[Token(Token = "0x401876E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _devouredImage;

		// Token: 0x0401876F RID: 100207
		[Token(Token = "0x401876F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _mutationImage;

		// Token: 0x04018770 RID: 100208
		[Token(Token = "0x4018770")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _selectImage;

		// Token: 0x04018771 RID: 100209
		[Token(Token = "0x4018771")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _wtrmanDisturbImage;

		// Token: 0x04018772 RID: 100210
		[Token(Token = "0x4018772")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _chosenOneImage;

		// Token: 0x04018773 RID: 100211
		[Token(Token = "0x4018773")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _ascensionImage;

		// Token: 0x04018774 RID: 100212
		[Token(Token = "0x4018774")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _angel2Image;

		// Token: 0x04018775 RID: 100213
		[Token(Token = "0x4018775")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _rl5RelicImage;

		// Token: 0x04018776 RID: 100214
		[Token(Token = "0x4018776")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _rl5CandleImage;

		// Token: 0x04018777 RID: 100215
		[Token(Token = "0x4018777")]
		[FieldOffset(Offset = "0xA0")]
		private RectTransform m_rectTransform;

		// Token: 0x04018778 RID: 100216
		[Token(Token = "0x4018778")]
		[FieldOffset(Offset = "0xA8")]
		private RectTransform m_targetRectTransform;

		// Token: 0x04018779 RID: 100217
		[Token(Token = "0x4018779")]
		[FieldOffset(Offset = "0xB0")]
		private List<UICardEffectHolder.CardEffectPlugin> m_plugins;

		// Token: 0x0401877A RID: 100218
		[Token(Token = "0x401877A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0401877B RID: 100219
		[Token(Token = "0x401877B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateEffect;

		// Token: 0x0401877C RID: 100220
		[Token(Token = "0x401877C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowSelectImage;

		// Token: 0x0401877D RID: 100221
		[Token(Token = "0x401877D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401877E RID: 100222
		[Token(Token = "0x401877E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401877F RID: 100223
		[Token(Token = "0x401877F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateCardEffectPlugin;

		// Token: 0x04018780 RID: 100224
		[Token(Token = "0x4018780")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RemoveCardEffectPlugin;

		// Token: 0x04018781 RID: 100225
		[Token(Token = "0x4018781")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032BF RID: 12991
		[Token(Token = "0x20032BF")]
		public abstract class CardEffectPlugin : IHotfixable
		{
			// Token: 0x170030E3 RID: 12515
			// (get) Token: 0x06014A4E RID: 84558 RVA: 0x00087DE0 File Offset: 0x00085FE0
			// (set) Token: 0x06014A4F RID: 84559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170030E3")]
			public bool isAttached
			{
				[Token(Token = "0x6014A4E")]
				[Address(RVA = "0xCDF4C0", Offset = "0xCDE0C0", VA = "0x180CDF4C0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6014A4F")]
				[Address(RVA = "0xCDF580", Offset = "0xCDE180", VA = "0x180CDF580")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170030E4 RID: 12516
			// (get) Token: 0x06014A50 RID: 84560 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170030E4")]
			protected RectTransform pluginObj
			{
				[Token(Token = "0x6014A50")]
				[Address(RVA = "0xCDF520", Offset = "0xCDE120", VA = "0x180CDF520")]
				get
				{
					return null;
				}
			}

			// Token: 0x06014A51 RID: 84561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A51")]
			[Address(RVA = "0xCDF440", Offset = "0xCDE040", VA = "0x180CDF440")]
			public CardEffectPlugin(RectTransform pluginPrefab)
			{
			}

			// Token: 0x06014A52 RID: 84562 RVA: 0x00087DF8 File Offset: 0x00085FF8
			[Token(Token = "0x6014A52")]
			[Address(RVA = "0xCDECE0", Offset = "0xCDD8E0", VA = "0x180CDECE0")]
			protected bool CreatePlugin(Transform parent)
			{
				return default(bool);
			}

			// Token: 0x06014A53 RID: 84563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A53")]
			[Address(RVA = "0xCDF240", Offset = "0xCDDE40", VA = "0x180CDF240")]
			private void _SetPluginParent(Transform parent)
			{
			}

			// Token: 0x06014A54 RID: 84564 RVA: 0x00087E10 File Offset: 0x00086010
			[Token(Token = "0x6014A54")]
			[Address(RVA = "0xCDE990", Offset = "0xCDD590", VA = "0x180CDE990")]
			public bool Attach(UICardEffectHolder holder)
			{
				return default(bool);
			}

			// Token: 0x06014A55 RID: 84565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A55")]
			[Address(RVA = "0xCDEE00", Offset = "0xCDDA00", VA = "0x180CDEE00")]
			public void Detach(UICardEffectHolder holder)
			{
			}

			// Token: 0x06014A56 RID: 84566 RVA: 0x00087E28 File Offset: 0x00086028
			[Token(Token = "0x6014A56")]
			[Address(RVA = "0xCDEF80", Offset = "0xCDDB80", VA = "0x180CDEF80")]
			protected bool DoReAttach(UICardEffectHolder holder)
			{
				return default(bool);
			}

			// Token: 0x06014A57 RID: 84567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A57")]
			[Address(RVA = "0xCDF120", Offset = "0xCDDD20", VA = "0x180CDF120", Slot = "4")]
			protected virtual void OnAttach(UICardEffectHolder holder)
			{
			}

			// Token: 0x06014A58 RID: 84568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A58")]
			[Address(RVA = "0xCDF180", Offset = "0xCDDD80", VA = "0x180CDF180", Slot = "5")]
			protected virtual void OnDetach()
			{
			}

			// Token: 0x06014A59 RID: 84569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A59")]
			[Address(RVA = "0xCDF1E0", Offset = "0xCDDDE0", VA = "0x180CDF1E0", Slot = "6")]
			public virtual void OnTick(FP deltaTime)
			{
			}

			// Token: 0x04018783 RID: 100227
			[Token(Token = "0x4018783")]
			[FieldOffset(Offset = "0x18")]
			private UICardEffectHolder m_holder;

			// Token: 0x04018784 RID: 100228
			[Token(Token = "0x4018784")]
			[FieldOffset(Offset = "0x20")]
			private RectTransform m_pluginObj;

			// Token: 0x04018785 RID: 100229
			[Token(Token = "0x4018785")]
			[FieldOffset(Offset = "0x28")]
			private RectTransform m_pluginPrefab;

			// Token: 0x04018786 RID: 100230
			[Token(Token = "0x4018786")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isAttached;

			// Token: 0x04018787 RID: 100231
			[Token(Token = "0x4018787")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isAttached;

			// Token: 0x04018788 RID: 100232
			[Token(Token = "0x4018788")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_pluginObj;

			// Token: 0x04018789 RID: 100233
			[Token(Token = "0x4018789")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401878A RID: 100234
			[Token(Token = "0x401878A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_CreatePlugin;

			// Token: 0x0401878B RID: 100235
			[Token(Token = "0x401878B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__SetPluginParent;

			// Token: 0x0401878C RID: 100236
			[Token(Token = "0x401878C")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Attach;

			// Token: 0x0401878D RID: 100237
			[Token(Token = "0x401878D")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_Detach;

			// Token: 0x0401878E RID: 100238
			[Token(Token = "0x401878E")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_DoReAttach;

			// Token: 0x0401878F RID: 100239
			[Token(Token = "0x401878F")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OnAttach;

			// Token: 0x04018790 RID: 100240
			[Token(Token = "0x4018790")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OnDetach;

			// Token: 0x04018791 RID: 100241
			[Token(Token = "0x4018791")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OnTick;
		}
	}
}
