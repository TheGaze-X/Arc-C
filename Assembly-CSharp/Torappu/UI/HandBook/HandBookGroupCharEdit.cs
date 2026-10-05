using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066E1 RID: 26337
	[Token(Token = "0x20066E1")]
	public class HandBookGroupCharEdit : HandBookGroupCommonPosEdit
	{
		// Token: 0x1700598E RID: 22926
		// (set) Token: 0x06025CA3 RID: 154787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700598E")]
		public float size
		{
			[Token(Token = "0x6025CA3")]
			[Address(RVA = "0x20B8630", Offset = "0x20B7230", VA = "0x1820B8630")]
			set
			{
			}
		}

		// Token: 0x1700598F RID: 22927
		// (get) Token: 0x06025CA4 RID: 154788 RVA: 0x000C9150 File Offset: 0x000C7350
		// (set) Token: 0x06025CA5 RID: 154789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700598F")]
		public bool isSelected
		{
			[Token(Token = "0x6025CA4")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025CA5")]
			[Address(RVA = "0x20B8550", Offset = "0x20B7150", VA = "0x1820B8550")]
			set
			{
			}
		}

		// Token: 0x06025CA6 RID: 154790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CA6")]
		[Address(RVA = "0x20B8340", Offset = "0x20B6F40", VA = "0x1820B8340")]
		public void Render(HandBookV2GroupPosData.CharData charData)
		{
		}

		// Token: 0x06025CA7 RID: 154791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CA7")]
		[Address(RVA = "0x20B8450", Offset = "0x20B7050", VA = "0x1820B8450")]
		public void SetSelect()
		{
		}

		// Token: 0x06025CA8 RID: 154792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CA8")]
		[Address(RVA = "0x20B8150", Offset = "0x20B6D50", VA = "0x1820B8150")]
		public void LargeSize()
		{
		}

		// Token: 0x06025CA9 RID: 154793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CA9")]
		[Address(RVA = "0x20B8190", Offset = "0x20B6D90", VA = "0x1820B8190")]
		public void LittleSize()
		{
		}

		// Token: 0x06025CAA RID: 154794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CAA")]
		[Address(RVA = "0x20B8290", Offset = "0x20B6E90", VA = "0x1820B8290")]
		public void RenderColor(string color)
		{
		}

		// Token: 0x06025CAB RID: 154795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CAB")]
		[Address(RVA = "0x20B81D0", Offset = "0x20B6DD0", VA = "0x1820B81D0")]
		public void NormalSize()
		{
		}

		// Token: 0x06025CAC RID: 154796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CAC")]
		[Address(RVA = "0x20B8200", Offset = "0x20B6E00", VA = "0x1820B8200", Slot = "8")]
		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06025CAD RID: 154797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CAD")]
		[Address(RVA = "0x20B8120", Offset = "0x20B6D20", VA = "0x1820B8120", Slot = "7")]
		public override void ApplyPos(Vector3 vect)
		{
		}

		// Token: 0x06025CAE RID: 154798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CAE")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookGroupCharEdit()
		{
		}

		// Token: 0x0403522C RID: 217644
		[Token(Token = "0x403522C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _isSelect;

		// Token: 0x0403522D RID: 217645
		[Token(Token = "0x403522D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _charHeadIcon;

		// Token: 0x0403522E RID: 217646
		[Token(Token = "0x403522E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _colorBack;

		// Token: 0x0403522F RID: 217647
		[Token(Token = "0x403522F")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isSelected;

		// Token: 0x04035230 RID: 217648
		[Token(Token = "0x4035230")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public HandBookV2GroupPosData.CharData cacheCharData;

		// Token: 0x04035231 RID: 217649
		[Token(Token = "0x4035231")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public HandBookV2GroupPosData.ForceData cacheForceData;
	}
}
