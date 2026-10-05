using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066E0 RID: 26336
	[Token(Token = "0x20066E0")]
	public class HandBookForceLogoEdit : HandBookGroupCommonPosEdit
	{
		// Token: 0x06025C9E RID: 154782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C9E")]
		[Address(RVA = "0x20B7F80", Offset = "0x20B6B80", VA = "0x1820B7F80", Slot = "7")]
		public override void ApplyPos(Vector3 vect)
		{
		}

		// Token: 0x06025C9F RID: 154783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C9F")]
		[Address(RVA = "0x20B7EE0", Offset = "0x20B6AE0", VA = "0x1820B7EE0")]
		public void AddForceDirection()
		{
		}

		// Token: 0x06025CA0 RID: 154784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CA0")]
		[Address(RVA = "0x20B7FC0", Offset = "0x20B6BC0", VA = "0x1820B7FC0")]
		public void ChangeForceDirection()
		{
		}

		// Token: 0x06025CA1 RID: 154785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CA1")]
		[Address(RVA = "0x20B8040", Offset = "0x20B6C40", VA = "0x1820B8040")]
		public void Render(HandBookV2GroupPosData.ForceData forceData)
		{
		}

		// Token: 0x06025CA2 RID: 154786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CA2")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookForceLogoEdit()
		{
		}

		// Token: 0x04035229 RID: 217641
		[Token(Token = "0x4035229")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _forceID;

		// Token: 0x0403522A RID: 217642
		[Token(Token = "0x403522A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _directionLogo;

		// Token: 0x0403522B RID: 217643
		[Token(Token = "0x403522B")]
		[FieldOffset(Offset = "0x38")]
		private HandBookV2GroupPosData.ForceData m_forceData;
	}
}
