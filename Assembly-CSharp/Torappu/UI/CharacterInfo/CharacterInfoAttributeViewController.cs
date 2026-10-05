using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F30 RID: 24368
	[Token(Token = "0x2005F30")]
	public class CharacterInfoAttributeViewController : DataBinder<CharInfoGroupProperty>
	{
		// Token: 0x060234AE RID: 144558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234AE")]
		[Address(RVA = "0x1DD65A0", Offset = "0x1DD51A0", VA = "0x181DD65A0", Slot = "7")]
		public override void OnValueChanged(CharInfoGroupProperty property)
		{
		}

		// Token: 0x060234AF RID: 144559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234AF")]
		[Address(RVA = "0x1DD63D0", Offset = "0x1DD4FD0", VA = "0x181DD63D0")]
		public void OnFavorShow()
		{
		}

		// Token: 0x060234B0 RID: 144560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234B0")]
		[Address(RVA = "0x1DD6330", Offset = "0x1DD4F30", VA = "0x181DD6330")]
		public void OnFavorDisable()
		{
		}

		// Token: 0x060234B1 RID: 144561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234B1")]
		[Address(RVA = "0x1DD6490", Offset = "0x1DD5090", VA = "0x181DD6490")]
		public void OnStateChange()
		{
		}

		// Token: 0x060234B2 RID: 144562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234B2")]
		[Address(RVA = "0x1DD70B0", Offset = "0x1DD5CB0", VA = "0x181DD70B0")]
		public void RefreshState()
		{
		}

		// Token: 0x060234B3 RID: 144563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234B3")]
		[Address(RVA = "0x1DD7140", Offset = "0x1DD5D40", VA = "0x181DD7140")]
		public CharacterInfoAttributeViewController()
		{
		}

		// Token: 0x04030AA3 RID: 199331
		[Token(Token = "0x4030AA3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _maxHp;

		// Token: 0x04030AA4 RID: 199332
		[Token(Token = "0x4030AA4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _atk;

		// Token: 0x04030AA5 RID: 199333
		[Token(Token = "0x4030AA5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _def;

		// Token: 0x04030AA6 RID: 199334
		[Token(Token = "0x4030AA6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _res;

		// Token: 0x04030AA7 RID: 199335
		[Token(Token = "0x4030AA7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _reviveTime;

		// Token: 0x04030AA8 RID: 199336
		[Token(Token = "0x4030AA8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _cost;

		// Token: 0x04030AA9 RID: 199337
		[Token(Token = "0x4030AA9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _blockNum;

		// Token: 0x04030AAA RID: 199338
		[Token(Token = "0x4030AAA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _atkSpeed;

		// Token: 0x04030AAB RID: 199339
		[Token(Token = "0x4030AAB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textPosition;

		// Token: 0x04030AAC RID: 199340
		[Token(Token = "0x4030AAC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textTags;

		// Token: 0x04030AAD RID: 199341
		[Token(Token = "0x4030AAD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _professionTab;

		// Token: 0x04030AAE RID: 199342
		[Token(Token = "0x4030AAE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Animator[] _animators;

		// Token: 0x04030AAF RID: 199343
		[Token(Token = "0x4030AAF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _buttonMask;

		// Token: 0x04030AB0 RID: 199344
		[Token(Token = "0x4030AB0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _hpRect;

		// Token: 0x04030AB1 RID: 199345
		[Token(Token = "0x4030AB1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _attackRect;

		// Token: 0x04030AB2 RID: 199346
		[Token(Token = "0x4030AB2")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _defRect;

		// Token: 0x04030AB3 RID: 199347
		[Token(Token = "0x4030AB3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _reRect;

		// Token: 0x04030AB4 RID: 199348
		[Token(Token = "0x4030AB4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _favourBar;

		// Token: 0x04030AB5 RID: 199349
		[Token(Token = "0x4030AB5")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _favourLvl;

		// Token: 0x04030AB6 RID: 199350
		[Token(Token = "0x4030AB6")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CharacterInfoFavourAttributeView _attrView;

		// Token: 0x04030AB7 RID: 199351
		[Token(Token = "0x4030AB7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Transform _attrContainer;

		// Token: 0x04030AB8 RID: 199352
		[Token(Token = "0x4030AB8")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Transform _panelPopup;

		// Token: 0x04030AB9 RID: 199353
		[Token(Token = "0x4030AB9")]
		[FieldOffset(Offset = "0xD0")]
		private List<CharacterInfoFavourAttributeView> m_attrLists;

		// Token: 0x04030ABA RID: 199354
		[Token(Token = "0x4030ABA")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_InOut;

		// Token: 0x04030ABB RID: 199355
		[Token(Token = "0x4030ABB")]
		private const float BARWIDTH = 382f;

		// Token: 0x04030ABC RID: 199356
		[Token(Token = "0x4030ABC")]
		private const float BARHEIGHT = 10f;

		// Token: 0x04030ABD RID: 199357
		[Token(Token = "0x4030ABD")]
		private const float WIDTH = 104f;

		// Token: 0x04030ABE RID: 199358
		[Token(Token = "0x4030ABE")]
		private const float HEIGHT = 23f;

		// Token: 0x04030ABF RID: 199359
		[Token(Token = "0x4030ABF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030AC0 RID: 199360
		[Token(Token = "0x4030AC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFavorShow;

		// Token: 0x04030AC1 RID: 199361
		[Token(Token = "0x4030AC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFavorDisable;

		// Token: 0x04030AC2 RID: 199362
		[Token(Token = "0x4030AC2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStateChange;

		// Token: 0x04030AC3 RID: 199363
		[Token(Token = "0x4030AC3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshState;

		// Token: 0x04030AC4 RID: 199364
		[Token(Token = "0x4030AC4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
