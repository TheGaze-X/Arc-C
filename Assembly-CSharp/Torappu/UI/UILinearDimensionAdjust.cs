using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003852 RID: 14418
	[Token(Token = "0x2003852")]
	public class UILinearDimensionAdjust : MonoBehaviour
	{
		// Token: 0x06016D73 RID: 93555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D73")]
		[Address(RVA = "0xF424F0", Offset = "0xF410F0", VA = "0x180F424F0")]
		private void Awake()
		{
		}

		// Token: 0x06016D74 RID: 93556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D74")]
		[Address(RVA = "0xF42570", Offset = "0xF41170", VA = "0x180F42570")]
		private void Update()
		{
		}

		// Token: 0x06016D75 RID: 93557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D75")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UILinearDimensionAdjust()
		{
		}

		// Token: 0x0401B8B9 RID: 112825
		[Token(Token = "0x401B8B9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _weightWidth;

		// Token: 0x0401B8BA RID: 112826
		[Token(Token = "0x401B8BA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _biasWidth;

		// Token: 0x0401B8BB RID: 112827
		[Token(Token = "0x401B8BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _weightHeight;

		// Token: 0x0401B8BC RID: 112828
		[Token(Token = "0x401B8BC")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _biasHeight;

		// Token: 0x0401B8BD RID: 112829
		[Token(Token = "0x401B8BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _applyWidth;

		// Token: 0x0401B8BE RID: 112830
		[Token(Token = "0x401B8BE")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _applyHeight;

		// Token: 0x0401B8BF RID: 112831
		[Token(Token = "0x401B8BF")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _useMinWidth;

		// Token: 0x0401B8C0 RID: 112832
		[Token(Token = "0x401B8C0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _minWidth;

		// Token: 0x0401B8C1 RID: 112833
		[Token(Token = "0x401B8C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _useMaxWidth;

		// Token: 0x0401B8C2 RID: 112834
		[Token(Token = "0x401B8C2")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _maxWidth;

		// Token: 0x0401B8C3 RID: 112835
		[Token(Token = "0x401B8C3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _useMinHeight;

		// Token: 0x0401B8C4 RID: 112836
		[Token(Token = "0x401B8C4")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _minHeight;

		// Token: 0x0401B8C5 RID: 112837
		[Token(Token = "0x401B8C5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _useMaxHeight;

		// Token: 0x0401B8C6 RID: 112838
		[Token(Token = "0x401B8C6")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _maxHeight;

		// Token: 0x0401B8C7 RID: 112839
		[Token(Token = "0x401B8C7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _targetRect;

		// Token: 0x0401B8C8 RID: 112840
		[Token(Token = "0x401B8C8")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform m_thisRect;
	}
}
