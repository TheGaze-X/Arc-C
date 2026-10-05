using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x0200751F RID: 29983
	[Token(Token = "0x200751F")]
	public class Act25sideResearchView : DataBinder<Act25sideResearchProperty>
	{
		// Token: 0x0602A404 RID: 173060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A404")]
		[Address(RVA = "0x25EB2E0", Offset = "0x25E9EE0", VA = "0x1825EB2E0")]
		public void Init(UIPage page)
		{
		}

		// Token: 0x0602A405 RID: 173061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A405")]
		[Address(RVA = "0x25EB360", Offset = "0x25E9F60", VA = "0x1825EB360", Slot = "7")]
		public override void OnValueChanged(Act25sideResearchProperty property)
		{
		}

		// Token: 0x0602A406 RID: 173062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A406")]
		[Address(RVA = "0x25EB6E0", Offset = "0x25EA2E0", VA = "0x1825EB6E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A407 RID: 173063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A407")]
		[Address(RVA = "0x25EB9C0", Offset = "0x25EA5C0", VA = "0x1825EB9C0")]
		public Act25sideResearchView()
		{
		}

		// Token: 0x0403CBCA RID: 248778
		[Token(Token = "0x403CBCA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _researchCount;

		// Token: 0x0403CBCB RID: 248779
		[Token(Token = "0x403CBCB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _areaItemContent;

		// Token: 0x0403CBCC RID: 248780
		[Token(Token = "0x403CBCC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act25sideResearchAreaView _areaViewPrefab;

		// Token: 0x0403CBCD RID: 248781
		[Token(Token = "0x403CBCD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _areaViewContainer;

		// Token: 0x0403CBCE RID: 248782
		[Token(Token = "0x403CBCE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelCount;

		// Token: 0x0403CBCF RID: 248783
		[Token(Token = "0x403CBCF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelMax;

		// Token: 0x0403CBD0 RID: 248784
		[Token(Token = "0x403CBD0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelAllComplete;

		// Token: 0x0403CBD1 RID: 248785
		[Token(Token = "0x403CBD1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelUnComplete;

		// Token: 0x0403CBD2 RID: 248786
		[Token(Token = "0x403CBD2")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0403CBD3 RID: 248787
		[Token(Token = "0x403CBD3")]
		[FieldOffset(Offset = "0x61")]
		private bool m_hasPlayedEnterAnim;

		// Token: 0x0403CBD4 RID: 248788
		[Token(Token = "0x403CBD4")]
		[FieldOffset(Offset = "0x68")]
		private Act25sideResearchView.AreaAdapter m_adapter;

		// Token: 0x0403CBD5 RID: 248789
		[Token(Token = "0x403CBD5")]
		[FieldOffset(Offset = "0x70")]
		private UIPage m_page;

		// Token: 0x0403CBD6 RID: 248790
		[Token(Token = "0x403CBD6")]
		[FieldOffset(Offset = "0x78")]
		private Act25sideResearchViewModel m_cachedViewModel;

		// Token: 0x0403CBD7 RID: 248791
		[Token(Token = "0x403CBD7")]
		[FieldOffset(Offset = "0x80")]
		private Act25sideResearchAreaView m_areaView;

		// Token: 0x0403CBD8 RID: 248792
		[Token(Token = "0x403CBD8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403CBD9 RID: 248793
		[Token(Token = "0x403CBD9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403CBDA RID: 248794
		[Token(Token = "0x403CBDA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CBDB RID: 248795
		[Token(Token = "0x403CBDB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007520 RID: 29984
		[Token(Token = "0x2007520")]
		private class AreaAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A408 RID: 173064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A408")]
			[Address(RVA = "0x25ECB20", Offset = "0x25EB720", VA = "0x1825ECB20")]
			public AreaAdapter(Act25sideResearchView closure)
			{
			}

			// Token: 0x17006369 RID: 25449
			// (get) Token: 0x0602A409 RID: 173065 RVA: 0x000D7C28 File Offset: 0x000D5E28
			[Token(Token = "0x17006369")]
			public override int count
			{
				[Token(Token = "0x602A409")]
				[Address(RVA = "0x25ECBA0", Offset = "0x25EB7A0", VA = "0x1825ECBA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A40A RID: 173066 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A40A")]
			[Address(RVA = "0x25EC940", Offset = "0x25EB540", VA = "0x1825EC940", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403CBDC RID: 248796
			[Token(Token = "0x403CBDC")]
			[FieldOffset(Offset = "0x20")]
			private Act25sideResearchView m_closure;

			// Token: 0x0403CBDD RID: 248797
			[Token(Token = "0x403CBDD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403CBDE RID: 248798
			[Token(Token = "0x403CBDE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403CBDF RID: 248799
			[Token(Token = "0x403CBDF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
