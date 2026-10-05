using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.CETest
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class CESelectButtonLevelControl : MonoBehaviour
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public string id
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public CETestDataLevel data
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x54D4980", Offset = "0x54D3580", VA = "0x1854D4980")]
		public void MyInit(string idNew, CETestDataLevel data, CETestControl parentControl)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x54D4BF0", Offset = "0x54D37F0", VA = "0x1854D4BF0")]
		public void SetMaskColor(Color color)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CESelectButtonLevelControl()
		{
		}

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image m_selectMask;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x20")]
		private string m_id;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x28")]
		private CETestDataLevel m_data;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x30")]
		private CETestControl m_parentControl;
	}
}
