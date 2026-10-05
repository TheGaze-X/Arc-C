using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Skin
{
	// Token: 0x02003EE3 RID: 16099
	[Token(Token = "0x2003EE3")]
	public class SkinSelectGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018F95 RID: 102293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F95")]
		[Address(RVA = "0x119F0F0", Offset = "0x119DCF0", VA = "0x18119F0F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018F96 RID: 102294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F96")]
		[Address(RVA = "0x119F070", Offset = "0x119DC70", VA = "0x18119F070")]
		public void InitData(List<SkinSelectViewModel> viewModel)
		{
		}

		// Token: 0x06018F97 RID: 102295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F97")]
		[Address(RVA = "0x119E830", Offset = "0x119D430", VA = "0x18119E830")]
		public void ApplyState(float state, bool shopTitleBarFlag)
		{
		}

		// Token: 0x06018F98 RID: 102296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F98")]
		[Address(RVA = "0x119F220", Offset = "0x119DE20", VA = "0x18119F220")]
		public SkinSelectGroupView()
		{
		}

		// Token: 0x0401ED80 RID: 126336
		[Token(Token = "0x401ED80")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _skinGroupObj;

		// Token: 0x0401ED81 RID: 126337
		[Token(Token = "0x401ED81")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _defaultSkinGroupObj;

		// Token: 0x0401ED82 RID: 126338
		[Token(Token = "0x401ED82")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _skinGroupConstText;

		// Token: 0x0401ED83 RID: 126339
		[Token(Token = "0x401ED83")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _defaultSkinGroupConstText;

		// Token: 0x0401ED84 RID: 126340
		[Token(Token = "0x401ED84")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _colorImgBack;

		// Token: 0x0401ED85 RID: 126341
		[Token(Token = "0x401ED85")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _defaultTypePart;

		// Token: 0x0401ED86 RID: 126342
		[Token(Token = "0x401ED86")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _buyableTypePart;

		// Token: 0x0401ED87 RID: 126343
		[Token(Token = "0x401ED87")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _leftContent;

		// Token: 0x0401ED88 RID: 126344
		[Token(Token = "0x401ED88")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _rightContent;

		// Token: 0x0401ED89 RID: 126345
		[Token(Token = "0x401ED89")]
		[FieldOffset(Offset = "0x60")]
		private SkinSelectGroupView.Adapter m_leftAdapter;

		// Token: 0x0401ED8A RID: 126346
		[Token(Token = "0x401ED8A")]
		[FieldOffset(Offset = "0x68")]
		private SkinSelectGroupView.Adapter m_rightAdapter;

		// Token: 0x0401ED8B RID: 126347
		[Token(Token = "0x401ED8B")]
		private const int MAXCOLORCOUNT = 10;

		// Token: 0x0401ED8C RID: 126348
		[Token(Token = "0x401ED8C")]
		[FieldOffset(Offset = "0x70")]
		private float m_currentScroll;

		// Token: 0x0401ED8D RID: 126349
		[Token(Token = "0x401ED8D")]
		[FieldOffset(Offset = "0x78")]
		private List<SkinSelectViewModel> m_viewModelList;

		// Token: 0x0401ED8E RID: 126350
		[Token(Token = "0x401ED8E")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0401ED8F RID: 126351
		[Token(Token = "0x401ED8F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401ED90 RID: 126352
		[Token(Token = "0x401ED90")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401ED91 RID: 126353
		[Token(Token = "0x401ED91")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyState;

		// Token: 0x0401ED92 RID: 126354
		[Token(Token = "0x401ED92")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003EE4 RID: 16100
		[Token(Token = "0x2003EE4")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003B8B RID: 15243
			// (get) Token: 0x06018F99 RID: 102297 RVA: 0x0009C7E0 File Offset: 0x0009A9E0
			[Token(Token = "0x17003B8B")]
			public override int count
			{
				[Token(Token = "0x6018F99")]
				[Address(RVA = "0x11958B0", Offset = "0x11944B0", VA = "0x1811958B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018F9A RID: 102298 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018F9A")]
			[Address(RVA = "0x11956A0", Offset = "0x11942A0", VA = "0x1811956A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06018F9B RID: 102299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018F9B")]
			[Address(RVA = "0x1195850", Offset = "0x1194450", VA = "0x181195850")]
			public Adapter()
			{
			}

			// Token: 0x0401ED93 RID: 126355
			[Token(Token = "0x401ED93")]
			[FieldOffset(Offset = "0x20")]
			public List<Color> colorList;

			// Token: 0x0401ED94 RID: 126356
			[Token(Token = "0x401ED94")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401ED95 RID: 126357
			[Token(Token = "0x401ED95")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401ED96 RID: 126358
			[Token(Token = "0x401ED96")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
