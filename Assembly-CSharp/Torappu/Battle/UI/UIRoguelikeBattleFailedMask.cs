using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003348 RID: 13128
	[Token(Token = "0x2003348")]
	public class UIRoguelikeBattleFailedMask : MonoBehaviour, IHotfixable
	{
		// Token: 0x06014F0F RID: 85775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F0F")]
		[Address(RVA = "0xD60CE0", Offset = "0xD5F8E0", VA = "0x180D60CE0", Slot = "4")]
		public virtual void OnPanelClick()
		{
		}

		// Token: 0x06014F10 RID: 85776 RVA: 0x00089910 File Offset: 0x00087B10
		[Token(Token = "0x6014F10")]
		[Address(RVA = "0xD60540", Offset = "0xD5F140", VA = "0x180D60540", Slot = "5")]
		public virtual bool BattleFailedPanelHide()
		{
			return default(bool);
		}

		// Token: 0x06014F11 RID: 85777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014F11")]
		[Address(RVA = "0xD605C0", Offset = "0xD5F1C0", VA = "0x180D605C0", Slot = "6")]
		public virtual RectTransform BattleFailedPanelInit()
		{
			return null;
		}

		// Token: 0x06014F12 RID: 85778 RVA: 0x00089928 File Offset: 0x00087B28
		[Token(Token = "0x6014F12")]
		[Address(RVA = "0xD606A0", Offset = "0xD5F2A0", VA = "0x180D606A0", Slot = "7")]
		public virtual bool BattleFailedPanelShow(string topicId, RoguelikeTopicMode mode)
		{
			return default(bool);
		}

		// Token: 0x06014F13 RID: 85779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F13")]
		[Address(RVA = "0xD60EA0", Offset = "0xD5FAA0", VA = "0x180D60EA0")]
		public UIRoguelikeBattleFailedMask()
		{
		}

		// Token: 0x04018E73 RID: 102003
		[Token(Token = "0x4018E73")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected UIAtlasObject _atlas;

		// Token: 0x04018E74 RID: 102004
		[Token(Token = "0x4018E74")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected UIAtlasImage _icon;

		// Token: 0x04018E75 RID: 102005
		[Token(Token = "0x4018E75")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected Text _title;

		// Token: 0x04018E76 RID: 102006
		[Token(Token = "0x4018E76")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected List<Text> _textHints;

		// Token: 0x04018E77 RID: 102007
		[Token(Token = "0x4018E77")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected float _fadeinDuration;

		// Token: 0x04018E78 RID: 102008
		[Token(Token = "0x4018E78")]
		[FieldOffset(Offset = "0x3C")]
		protected readonly int HINT_COUNT;

		// Token: 0x04018E79 RID: 102009
		[Token(Token = "0x4018E79")]
		[FieldOffset(Offset = "0x40")]
		protected readonly string HINT_PREFIX;

		// Token: 0x04018E7A RID: 102010
		[Token(Token = "0x4018E7A")]
		[FieldOffset(Offset = "0x48")]
		protected CanvasGroup m_canvasGroup;

		// Token: 0x04018E7B RID: 102011
		[Token(Token = "0x4018E7B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPanelClick;

		// Token: 0x04018E7C RID: 102012
		[Token(Token = "0x4018E7C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BattleFailedPanelHide;

		// Token: 0x04018E7D RID: 102013
		[Token(Token = "0x4018E7D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BattleFailedPanelInit;

		// Token: 0x04018E7E RID: 102014
		[Token(Token = "0x4018E7E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BattleFailedPanelShow;

		// Token: 0x04018E7F RID: 102015
		[Token(Token = "0x4018E7F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
