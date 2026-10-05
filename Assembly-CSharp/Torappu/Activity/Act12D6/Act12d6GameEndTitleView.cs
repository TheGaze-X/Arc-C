using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AEB RID: 31467
	[Token(Token = "0x2007AEB")]
	public class Act12d6GameEndTitleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C11B RID: 180507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C11B")]
		[Address(RVA = "0x27FD810", Offset = "0x27FC410", VA = "0x1827FD810")]
		public void Render(Act12D6GameEndViewModel viewModel)
		{
		}

		// Token: 0x0602C11C RID: 180508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C11C")]
		[Address(RVA = "0x27FE070", Offset = "0x27FCC70", VA = "0x1827FE070")]
		private Sprite _GetTitleSprite(string id)
		{
			return null;
		}

		// Token: 0x0602C11D RID: 180509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C11D")]
		[Address(RVA = "0x27FDF30", Offset = "0x27FCB30", VA = "0x1827FDF30")]
		private Sprite _GetLogoSprite(string id)
		{
			return null;
		}

		// Token: 0x0602C11E RID: 180510 RVA: 0x000DE060 File Offset: 0x000DC260
		[Token(Token = "0x602C11E")]
		[Address(RVA = "0x27FDDB0", Offset = "0x27FC9B0", VA = "0x1827FDDB0")]
		private Vector2 _GetLogoSize(string id)
		{
			return default(Vector2);
		}

		// Token: 0x0602C11F RID: 180511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C11F")]
		[Address(RVA = "0x27FE260", Offset = "0x27FCE60", VA = "0x1827FE260")]
		private void _TryPlayLogoTween()
		{
		}

		// Token: 0x0602C120 RID: 180512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C120")]
		[Address(RVA = "0x27FE1B0", Offset = "0x27FCDB0", VA = "0x1827FE1B0")]
		private IEnumerator _PlayLogoTween()
		{
			return null;
		}

		// Token: 0x0602C121 RID: 180513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C121")]
		[Address(RVA = "0x27FD6C0", Offset = "0x27FC2C0", VA = "0x1827FD6C0")]
		public void OnEnable()
		{
		}

		// Token: 0x0602C122 RID: 180514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C122")]
		[Address(RVA = "0x27FE370", Offset = "0x27FCF70", VA = "0x1827FE370")]
		public Act12d6GameEndTitleView()
		{
		}

		// Token: 0x0403FDB4 RID: 261556
		[Token(Token = "0x403FDB4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Settings")]
		private List<Act12d6GameEndTitleView.EndingData> _endingDatas;

		// Token: 0x0403FDB5 RID: 261557
		[Token(Token = "0x403FDB5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Settings")]
		private float _logoTweenDuration;

		// Token: 0x0403FDB6 RID: 261558
		[Token(Token = "0x403FDB6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageBkgFail;

		// Token: 0x0403FDB7 RID: 261559
		[Token(Token = "0x403FDB7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imageBkgEnding;

		// Token: 0x0403FDB8 RID: 261560
		[Token(Token = "0x403FDB8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imageTitle;

		// Token: 0x0403FDB9 RID: 261561
		[Token(Token = "0x403FDB9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HorizontalLayoutGroup _logoLayoutGroup;

		// Token: 0x0403FDBA RID: 261562
		[Token(Token = "0x403FDBA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<Image> _logos;

		// Token: 0x0403FDBB RID: 261563
		[Token(Token = "0x403FDBB")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x0403FDBC RID: 261564
		[Token(Token = "0x403FDBC")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_tweener;

		// Token: 0x0403FDBD RID: 261565
		[Token(Token = "0x403FDBD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FDBE RID: 261566
		[Token(Token = "0x403FDBE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetTitleSprite;

		// Token: 0x0403FDBF RID: 261567
		[Token(Token = "0x403FDBF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetLogoSprite;

		// Token: 0x0403FDC0 RID: 261568
		[Token(Token = "0x403FDC0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetLogoSize;

		// Token: 0x0403FDC1 RID: 261569
		[Token(Token = "0x403FDC1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryPlayLogoTween;

		// Token: 0x0403FDC2 RID: 261570
		[Token(Token = "0x403FDC2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayLogoTween;

		// Token: 0x0403FDC3 RID: 261571
		[Token(Token = "0x403FDC3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403FDC4 RID: 261572
		[Token(Token = "0x403FDC4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007AEC RID: 31468
		[Token(Token = "0x2007AEC")]
		[Serializable]
		private class EndingData
		{
			// Token: 0x0602C123 RID: 180515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C123")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EndingData()
			{
			}

			// Token: 0x0403FDC5 RID: 261573
			[Token(Token = "0x403FDC5")]
			[FieldOffset(Offset = "0x10")]
			public string endingId;

			// Token: 0x0403FDC6 RID: 261574
			[Token(Token = "0x403FDC6")]
			[FieldOffset(Offset = "0x18")]
			public Sprite titleSprite;

			// Token: 0x0403FDC7 RID: 261575
			[Token(Token = "0x403FDC7")]
			[FieldOffset(Offset = "0x20")]
			public Sprite logoSprite;

			// Token: 0x0403FDC8 RID: 261576
			[Token(Token = "0x403FDC8")]
			[FieldOffset(Offset = "0x28")]
			public Vector2 logoSize;
		}
	}
}
