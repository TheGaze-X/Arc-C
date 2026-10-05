using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003A2D RID: 14893
	[Token(Token = "0x2003A2D")]
	public class UIScaler : MonoBehaviour
	{
		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x06017822 RID: 96290 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017823 RID: 96291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003850")]
		public Action<float> onScalerChange
		{
			[Token(Token = "0x6017822")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6017823")]
			[Address(RVA = "0xFD3250", Offset = "0xFD1E50", VA = "0x180FD3250")]
			set
			{
			}
		}

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x06017824 RID: 96292 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017825 RID: 96293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003851")]
		[Inspect]
		public RectTransform scaleTarget
		{
			[Token(Token = "0x6017824")]
			[Address(RVA = "0xFD31B0", Offset = "0xFD1DB0", VA = "0x180FD31B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017825")]
			[Address(RVA = "0xFD3290", Offset = "0xFD1E90", VA = "0x180FD3290")]
			set
			{
			}
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x06017826 RID: 96294 RVA: 0x00096DE0 File Offset: 0x00094FE0
		// (set) Token: 0x06017827 RID: 96295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003852")]
		[Inspect]
		public float scale
		{
			[Token(Token = "0x6017826")]
			[Address(RVA = "0x7E7500", Offset = "0x7E6100", VA = "0x1807E7500")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6017827")]
			[Address(RVA = "0xFD33A0", Offset = "0xFD1FA0", VA = "0x180FD33A0")]
			set
			{
			}
		}

		// Token: 0x06017828 RID: 96296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017828")]
		[Address(RVA = "0xFD25C0", Offset = "0xFD11C0", VA = "0x180FD25C0")]
		[Inspect]
		public void TakeScaleRawValue()
		{
		}

		// Token: 0x06017829 RID: 96297 RVA: 0x00096DF8 File Offset: 0x00094FF8
		[Token(Token = "0x6017829")]
		[Address(RVA = "0xFD26C0", Offset = "0xFD12C0", VA = "0x180FD26C0")]
		private UIScaler.UIInfo _AchieveUIInfo(RectTransform transform)
		{
			return default(UIScaler.UIInfo);
		}

		// Token: 0x0601782A RID: 96298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601782A")]
		[Address(RVA = "0xFD2B80", Offset = "0xFD1780", VA = "0x180FD2B80")]
		private void _ParseUIInfos(RectTransform transform)
		{
		}

		// Token: 0x0601782B RID: 96299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601782B")]
		[Address(RVA = "0xFD2D40", Offset = "0xFD1940", VA = "0x180FD2D40")]
		private void _ResetScale(float scale)
		{
		}

		// Token: 0x0601782C RID: 96300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601782C")]
		[Address(RVA = "0xFD3120", Offset = "0xFD1D20", VA = "0x180FD3120")]
		public UIScaler()
		{
		}

		// Token: 0x0401C633 RID: 116275
		[Token(Token = "0x401C633")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private RectTransform _scaleTarget;

		// Token: 0x0401C634 RID: 116276
		[Token(Token = "0x401C634")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private List<UIScaler.UIInfo> _scaleInfo;

		// Token: 0x0401C635 RID: 116277
		[Token(Token = "0x401C635")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private float _scale;

		// Token: 0x0401C636 RID: 116278
		[Token(Token = "0x401C636")]
		[FieldOffset(Offset = "0x30")]
		private Action<float> m_onScalerChange;

		// Token: 0x02003A2E RID: 14894
		[Token(Token = "0x2003A2E")]
		[Serializable]
		public struct UIInfo
		{
			// Token: 0x0401C637 RID: 116279
			[Token(Token = "0x401C637")]
			[FieldOffset(Offset = "0x0")]
			public RectTransform transform;

			// Token: 0x0401C638 RID: 116280
			[Token(Token = "0x401C638")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 anchoredPosition;

			// Token: 0x0401C639 RID: 116281
			[Token(Token = "0x401C639")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 sizeDelta;

			// Token: 0x0401C63A RID: 116282
			[Token(Token = "0x401C63A")]
			[FieldOffset(Offset = "0x18")]
			public Text text;

			// Token: 0x0401C63B RID: 116283
			[Token(Token = "0x401C63B")]
			[FieldOffset(Offset = "0x20")]
			public int fontMinSize;

			// Token: 0x0401C63C RID: 116284
			[Token(Token = "0x401C63C")]
			[FieldOffset(Offset = "0x24")]
			public int fontMaxSize;

			// Token: 0x0401C63D RID: 116285
			[Token(Token = "0x401C63D")]
			[FieldOffset(Offset = "0x28")]
			public int fontSize;

			// Token: 0x0401C63E RID: 116286
			[Token(Token = "0x401C63E")]
			[FieldOffset(Offset = "0x2C")]
			public bool isBestFit;

			// Token: 0x0401C63F RID: 116287
			[Token(Token = "0x401C63F")]
			[FieldOffset(Offset = "0x30")]
			public LayoutElement layoutElement;

			// Token: 0x0401C640 RID: 116288
			[Token(Token = "0x401C640")]
			[FieldOffset(Offset = "0x38")]
			public Vector2 preferredSize;

			// Token: 0x0401C641 RID: 116289
			[Token(Token = "0x401C641")]
			[FieldOffset(Offset = "0x40")]
			public Vector3 minSize;

			// Token: 0x0401C642 RID: 116290
			[Token(Token = "0x401C642")]
			[FieldOffset(Offset = "0x50")]
			public LayoutGroup layoutGroup;

			// Token: 0x0401C643 RID: 116291
			[Token(Token = "0x401C643")]
			[FieldOffset(Offset = "0x58")]
			public Vector4 padding;
		}
	}
}
