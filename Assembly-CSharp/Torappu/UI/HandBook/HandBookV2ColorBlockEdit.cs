using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066E7 RID: 26343
	[Token(Token = "0x20066E7")]
	public class HandBookV2ColorBlockEdit : HandBookGroupCommonPosEdit
	{
		// Token: 0x17005993 RID: 22931
		// (get) Token: 0x06025CE0 RID: 154848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005993")]
		public HandBookV2GroupPosData.ColoringBlockData colorBlockData
		{
			[Token(Token = "0x6025CE0")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025CE1 RID: 154849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CE1")]
		[Address(RVA = "0x20BF010", Offset = "0x20BDC10", VA = "0x1820BF010", Slot = "7")]
		public override void ApplyPos(Vector3 vect)
		{
		}

		// Token: 0x06025CE2 RID: 154850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CE2")]
		[Address(RVA = "0x20BF050", Offset = "0x20BDC50", VA = "0x1820BF050")]
		public void RemoveThisColor()
		{
		}

		// Token: 0x06025CE3 RID: 154851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CE3")]
		[Address(RVA = "0x20BF390", Offset = "0x20BDF90", VA = "0x1820BF390")]
		public void RenderColorBlock(HandBookV2GroupPosData.ColoringBlockData colorBlock)
		{
		}

		// Token: 0x06025CE4 RID: 154852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CE4")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookV2ColorBlockEdit()
		{
		}

		// Token: 0x04035265 RID: 217701
		[Token(Token = "0x4035265")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _color;

		// Token: 0x04035266 RID: 217702
		[Token(Token = "0x4035266")]
		[FieldOffset(Offset = "0x30")]
		private HandBookV2GroupPosData.ColoringBlockData m_colorBlockData;
	}
}
