using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.CETest
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class CESelectButtonSquadControl : MonoBehaviour
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		public string id
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		public CETestDataSquad data
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x54D4CA0", Offset = "0x54D38A0", VA = "0x1854D4CA0")]
		public void MyInit(string idNew, CETestDataSquad data, CETestControl parentControl)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x54D4F10", Offset = "0x54D3B10", VA = "0x1854D4F10")]
		public void SetMaskColor(Color color)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CESelectButtonSquadControl()
		{
		}

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _selectMask;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x20")]
		private string m_id;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x28")]
		private CETestDataSquad m_data;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x30")]
		private CETestControl m_parentControl;
	}
}
