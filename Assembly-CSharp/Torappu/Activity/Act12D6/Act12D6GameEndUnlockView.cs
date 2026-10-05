using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Roguelike;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AEF RID: 31471
	[Token(Token = "0x2007AEF")]
	public class Act12D6GameEndUnlockView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C12C RID: 180524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C12C")]
		[Address(RVA = "0x27F1930", Offset = "0x27F0530", VA = "0x1827F1930")]
		public void Render(Act12D6GameEndStateBean stateBean)
		{
		}

		// Token: 0x0602C12D RID: 180525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C12D")]
		[Address(RVA = "0x27F1C70", Offset = "0x27F0870", VA = "0x1827F1C70")]
		public void ShotBlurBkg()
		{
		}

		// Token: 0x0602C12E RID: 180526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C12E")]
		[Address(RVA = "0x27F1DC0", Offset = "0x27F09C0", VA = "0x1827F1DC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602C12F RID: 180527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C12F")]
		[Address(RVA = "0x27F1E40", Offset = "0x27F0A40", VA = "0x1827F1E40")]
		public Act12D6GameEndUnlockView()
		{
		}

		// Token: 0x0403FDD1 RID: 261585
		[Token(Token = "0x403FDD1")]
		private const string CNT_FORMAT = "x {0}";

		// Token: 0x0403FDD2 RID: 261586
		[Token(Token = "0x403FDD2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _relicContainer;

		// Token: 0x0403FDD3 RID: 261587
		[Token(Token = "0x403FDD3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIFullScreenImage _imageBlurBkg;

		// Token: 0x0403FDD4 RID: 261588
		[Token(Token = "0x403FDD4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textUnlockCnt;

		// Token: 0x0403FDD5 RID: 261589
		[Token(Token = "0x403FDD5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imageOutBuffToken;

		// Token: 0x0403FDD6 RID: 261590
		[Token(Token = "0x403FDD6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textOutBuffTokenName;

		// Token: 0x0403FDD7 RID: 261591
		[Token(Token = "0x403FDD7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textOutBuffTokenCount;

		// Token: 0x0403FDD8 RID: 261592
		[Token(Token = "0x403FDD8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imageMilestoneToken;

		// Token: 0x0403FDD9 RID: 261593
		[Token(Token = "0x403FDD9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textMilestoneTokenName;

		// Token: 0x0403FDDA RID: 261594
		[Token(Token = "0x403FDDA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textMilestoneTokenCount;

		// Token: 0x0403FDDB RID: 261595
		[Token(Token = "0x403FDDB")]
		[FieldOffset(Offset = "0x60")]
		private bool m_inited;

		// Token: 0x0403FDDC RID: 261596
		[Token(Token = "0x403FDDC")]
		[FieldOffset(Offset = "0x68")]
		private Act12D6GameEndUnlockView.Adapter m_adapter;

		// Token: 0x0403FDDD RID: 261597
		[Token(Token = "0x403FDDD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FDDE RID: 261598
		[Token(Token = "0x403FDDE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShotBlurBkg;

		// Token: 0x0403FDDF RID: 261599
		[Token(Token = "0x403FDDF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FDE0 RID: 261600
		[Token(Token = "0x403FDE0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007AF0 RID: 31472
		[Token(Token = "0x2007AF0")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17006744 RID: 26436
			// (get) Token: 0x0602C130 RID: 180528 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602C131 RID: 180529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17006744")]
			public List<RoguelikeRelicViewModel> dataSet
			{
				[Token(Token = "0x602C130")]
				[Address(RVA = "0x2801020", Offset = "0x27FFC20", VA = "0x182801020")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x602C131")]
				[Address(RVA = "0x2801080", Offset = "0x27FFC80", VA = "0x182801080")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17006745 RID: 26437
			// (get) Token: 0x0602C132 RID: 180530 RVA: 0x000DE090 File Offset: 0x000DC290
			[Token(Token = "0x17006745")]
			public override int count
			{
				[Token(Token = "0x602C132")]
				[Address(RVA = "0x2800F60", Offset = "0x27FFB60", VA = "0x182800F60", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602C133 RID: 180531 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C133")]
			[Address(RVA = "0x2800C90", Offset = "0x27FF890", VA = "0x182800C90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602C134 RID: 180532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C134")]
			[Address(RVA = "0x2800F00", Offset = "0x27FFB00", VA = "0x182800F00")]
			public Adapter()
			{
			}

			// Token: 0x0403FDE2 RID: 261602
			[Token(Token = "0x403FDE2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x0403FDE3 RID: 261603
			[Token(Token = "0x403FDE3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x0403FDE4 RID: 261604
			[Token(Token = "0x403FDE4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403FDE5 RID: 261605
			[Token(Token = "0x403FDE5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403FDE6 RID: 261606
			[Token(Token = "0x403FDE6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
