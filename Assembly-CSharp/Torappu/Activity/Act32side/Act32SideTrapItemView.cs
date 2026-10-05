using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.TemplateTrap;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act32side
{
	// Token: 0x02007487 RID: 29831
	[Token(Token = "0x2007487")]
	public class Act32SideTrapItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A128 RID: 172328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A128")]
		[Address(RVA = "0x25BCFA0", Offset = "0x25BBBA0", VA = "0x1825BCFA0")]
		public void RenderView(int currentSelectCount, int maxSelectCount, TemplateTrapViewModel trapViewModel)
		{
		}

		// Token: 0x0602A129 RID: 172329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A129")]
		[Address(RVA = "0x25BCEF0", Offset = "0x25BBAF0", VA = "0x1825BCEF0")]
		public void OnClick()
		{
		}

		// Token: 0x0602A12A RID: 172330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A12A")]
		[Address(RVA = "0x25BD2B0", Offset = "0x25BBEB0", VA = "0x1825BD2B0")]
		public Act32SideTrapItemView()
		{
		}

		// Token: 0x0403C61B RID: 247323
		[Token(Token = "0x403C61B")]
		private const string SMALL_ICON_PATH = "{0}_small";

		// Token: 0x0403C61C RID: 247324
		[Token(Token = "0x403C61C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _iconImg;

		// Token: 0x0403C61D RID: 247325
		[Token(Token = "0x403C61D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectBar;

		// Token: 0x0403C61E RID: 247326
		[Token(Token = "0x403C61E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _unlockPart;

		// Token: 0x0403C61F RID: 247327
		[Token(Token = "0x403C61F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lockedPart;

		// Token: 0x0403C620 RID: 247328
		[Token(Token = "0x403C620")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _tinyIcon;

		// Token: 0x0403C621 RID: 247329
		[Token(Token = "0x403C621")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _name;

		// Token: 0x0403C622 RID: 247330
		[Token(Token = "0x403C622")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _detail;

		// Token: 0x0403C623 RID: 247331
		[Token(Token = "0x403C623")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _isNewFlag;

		// Token: 0x0403C624 RID: 247332
		[Token(Token = "0x403C624")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _unlockText;

		// Token: 0x0403C625 RID: 247333
		[Token(Token = "0x403C625")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0403C626 RID: 247334
		[Token(Token = "0x403C626")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _clipName;

		// Token: 0x0403C627 RID: 247335
		[Token(Token = "0x403C627")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<string, int> onSelectAction;

		// Token: 0x0403C628 RID: 247336
		[Token(Token = "0x403C628")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public UIAtlasObject trapHub;

		// Token: 0x0403C629 RID: 247337
		[Token(Token = "0x403C629")]
		[FieldOffset(Offset = "0x80")]
		private int m_currentSelectCount;

		// Token: 0x0403C62A RID: 247338
		[Token(Token = "0x403C62A")]
		[FieldOffset(Offset = "0x84")]
		private int m_maxSelectCount;

		// Token: 0x0403C62B RID: 247339
		[Token(Token = "0x403C62B")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isSelectedCache;

		// Token: 0x0403C62C RID: 247340
		[Token(Token = "0x403C62C")]
		[FieldOffset(Offset = "0x90")]
		private TemplateTrapViewModel m_trapViewModel;

		// Token: 0x0403C62D RID: 247341
		[Token(Token = "0x403C62D")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_tween;

		// Token: 0x0403C62E RID: 247342
		[Token(Token = "0x403C62E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403C62F RID: 247343
		[Token(Token = "0x403C62F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403C630 RID: 247344
		[Token(Token = "0x403C630")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
