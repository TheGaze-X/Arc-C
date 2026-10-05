using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001DA7 RID: 7591
	[Token(Token = "0x2001DA7")]
	public class BuildingManufactOutputCountView : DataBinder<MRoomViewPropety>
	{
		// Token: 0x0600BB2B RID: 47915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB2B")]
		[Address(RVA = "0x3391EB0", Offset = "0x3390AB0", VA = "0x183391EB0", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600BB2C RID: 47916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB2C")]
		[Address(RVA = "0x3391FB0", Offset = "0x3390BB0", VA = "0x183391FB0", Slot = "7")]
		public override void OnValueChanged(MRoomViewPropety property)
		{
		}

		// Token: 0x0600BB2D RID: 47917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB2D")]
		[Address(RVA = "0x3392690", Offset = "0x3391290", VA = "0x183392690")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600BB2E RID: 47918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BB2E")]
		[Address(RVA = "0x3392790", Offset = "0x3391390", VA = "0x183392790")]
		private IEnumerator _UpdateLayoutCoroutine()
		{
			return null;
		}

		// Token: 0x0600BB2F RID: 47919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB2F")]
		[Address(RVA = "0x33924F0", Offset = "0x33910F0", VA = "0x1833924F0")]
		private void _AdjustVirtualProgress(MRoomViewModel viewModel)
		{
		}

		// Token: 0x0600BB30 RID: 47920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB30")]
		[Address(RVA = "0x3392840", Offset = "0x3391440", VA = "0x183392840")]
		public BuildingManufactOutputCountView()
		{
		}

		// Token: 0x0400BAA6 RID: 47782
		[Token(Token = "0x400BAA6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0400BAA7 RID: 47783
		[Token(Token = "0x400BAA7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textLimit;

		// Token: 0x0400BAA8 RID: 47784
		[Token(Token = "0x400BAA8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _lineLayout;

		// Token: 0x0400BAA9 RID: 47785
		[Token(Token = "0x400BAA9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private StretchProgressBar _progress;

		// Token: 0x0400BAAA RID: 47786
		[Token(Token = "0x400BAAA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Progress when editing")]
		private Image _virtualProgress;

		// Token: 0x0400BAAB RID: 47787
		[Token(Token = "0x400BAAB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorVirtualNormal;

		// Token: 0x0400BAAC RID: 47788
		[Token(Token = "0x400BAAC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _colorVirtualHilight;

		// Token: 0x0400BAAD RID: 47789
		[Token(Token = "0x400BAAD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _colorCountHilight;

		// Token: 0x0400BAAE RID: 47790
		[Token(Token = "0x400BAAE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelOverrloaded;

		// Token: 0x0400BAAF RID: 47791
		[Token(Token = "0x400BAAF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textOverloaded;

		// Token: 0x0400BAB0 RID: 47792
		[Token(Token = "0x400BAB0")]
		[FieldOffset(Offset = "0x88")]
		private string m_colorCountHilightCode;

		// Token: 0x0400BAB1 RID: 47793
		[Token(Token = "0x400BAB1")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0400BAB2 RID: 47794
		[Token(Token = "0x400BAB2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400BAB3 RID: 47795
		[Token(Token = "0x400BAB3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400BAB4 RID: 47796
		[Token(Token = "0x400BAB4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400BAB5 RID: 47797
		[Token(Token = "0x400BAB5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateLayoutCoroutine;

		// Token: 0x0400BAB6 RID: 47798
		[Token(Token = "0x400BAB6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__AdjustVirtualProgress;

		// Token: 0x0400BAB7 RID: 47799
		[Token(Token = "0x400BAB7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
