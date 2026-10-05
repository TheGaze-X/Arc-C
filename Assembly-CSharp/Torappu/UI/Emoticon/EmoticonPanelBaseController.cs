using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050D8 RID: 20696
	[Token(Token = "0x20050D8")]
	public abstract class EmoticonPanelBaseController<TModel> : MonoBehaviour, IHotfixable where TModel : EmoticonPanelBaseModel
	{
		// Token: 0x0601E9A3 RID: 125347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9A3")]
		public virtual void ShowEmoticonPanel(PanelInputParam input)
		{
		}

		// Token: 0x0601E9A4 RID: 125348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9A4")]
		public virtual void HideEmoticonPanel(bool isFastMode)
		{
		}

		// Token: 0x0601E9A5 RID: 125349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9A5")]
		public virtual void ShowReceiveEmojiItem(PopEmojiItemInputParam input)
		{
		}

		// Token: 0x0601E9A6 RID: 125350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9A6")]
		public virtual void HideReceiveEmojiItem(PlayerIndex index, bool isFastMode)
		{
		}

		// Token: 0x0601E9A7 RID: 125351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9A7")]
		public void HideAll(bool isFastMode)
		{
		}

		// Token: 0x0601E9A8 RID: 125352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9A8")]
		protected virtual void _OnSendEmoji(string themeId, string emojiItem)
		{
		}

		// Token: 0x0601E9A9 RID: 125353
		[Token(Token = "0x601E9A9")]
		protected abstract void _InitPagerCallBack(EmoticonPanelBaseView view);

		// Token: 0x0601E9AA RID: 125354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9AA")]
		private void _TriggerEmojiCoolDown()
		{
		}

		// Token: 0x0601E9AB RID: 125355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9AB")]
		protected EmoticonPanelBaseController()
		{
		}

		// Token: 0x04029024 RID: 167972
		[Token(Token = "0x4029024")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private EmoticonPanelBaseView _panelViewPrefab;

		// Token: 0x04029025 RID: 167973
		[Token(Token = "0x4029025")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private EmoticonPopEmojiItemBaseView _popEmojiItemViewPrefab;

		// Token: 0x04029026 RID: 167974
		[Token(Token = "0x4029026")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform _panelContainer;

		// Token: 0x04029027 RID: 167975
		[Token(Token = "0x4029027")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform _popEmojiItemContainer;

		// Token: 0x04029028 RID: 167976
		[Token(Token = "0x4029028")]
		[FieldOffset(Offset = "0x0")]
		protected EmoticonPanelProperty m_prop;

		// Token: 0x04029029 RID: 167977
		[Token(Token = "0x4029029")]
		[FieldOffset(Offset = "0x0")]
		private EmoticonPanelBaseView m_panelView;

		// Token: 0x0402902A RID: 167978
		[Token(Token = "0x402902A")]
		[FieldOffset(Offset = "0x0")]
		private ListDict<PlayerIndex, PopEmojiGroup> m_popEmojiItemList;

		// Token: 0x0402902B RID: 167979
		[Token(Token = "0x402902B")]
		[FieldOffset(Offset = "0x0")]
		private PanelInputParam m_cachedPanelInput;

		// Token: 0x0402902C RID: 167980
		[Token(Token = "0x402902C")]
		[FieldOffset(Offset = "0x0")]
		private IEmoticonCustomConfig m_customConfig;

		// Token: 0x0402902D RID: 167981
		[Token(Token = "0x402902D")]
		[FieldOffset(Offset = "0x0")]
		private ILoadAsset m_assetLoader;

		// Token: 0x0402902E RID: 167982
		[Token(Token = "0x402902E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowEmoticonPanel;

		// Token: 0x0402902F RID: 167983
		[Token(Token = "0x402902F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HideEmoticonPanel;

		// Token: 0x04029030 RID: 167984
		[Token(Token = "0x4029030")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowReceiveEmojiItem;

		// Token: 0x04029031 RID: 167985
		[Token(Token = "0x4029031")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HideReceiveEmojiItem;

		// Token: 0x04029032 RID: 167986
		[Token(Token = "0x4029032")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HideAll;

		// Token: 0x04029033 RID: 167987
		[Token(Token = "0x4029033")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnSendEmoji;

		// Token: 0x04029034 RID: 167988
		[Token(Token = "0x4029034")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__TriggerEmojiCoolDown;

		// Token: 0x04029035 RID: 167989
		[Token(Token = "0x4029035")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
