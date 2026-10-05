using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.DevTester
{
	// Token: 0x02005106 RID: 20742
	[Token(Token = "0x2005106")]
	public class UIDebugSocPanel : MonoBehaviour
	{
		// Token: 0x0601EA1C RID: 125468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EA1C")]
		[Address(RVA = "0x18655B0", Offset = "0x18641B0", VA = "0x1818655B0")]
		private string _GetPlatform()
		{
			return null;
		}

		// Token: 0x0601EA1D RID: 125469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EA1D")]
		[Address(RVA = "0x1865620", Offset = "0x1864220", VA = "0x181865620")]
		private string _GetProcessor()
		{
			return null;
		}

		// Token: 0x0601EA1E RID: 125470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EA1E")]
		[Address(RVA = "0x1865520", Offset = "0x1864120", VA = "0x181865520")]
		private string _GetIsSimulator()
		{
			return null;
		}

		// Token: 0x0601EA1F RID: 125471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EA1F")]
		[Address(RVA = "0x1865660", Offset = "0x1864260", VA = "0x181865660")]
		private string _GetSoc()
		{
			return null;
		}

		// Token: 0x0601EA20 RID: 125472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA20")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIDebugSocPanel()
		{
		}

		// Token: 0x04029140 RID: 168256
		[Token(Token = "0x4029140")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _platform;

		// Token: 0x04029141 RID: 168257
		[Token(Token = "0x4029141")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _isSimulator;

		// Token: 0x04029142 RID: 168258
		[Token(Token = "0x4029142")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _soc;

		// Token: 0x04029143 RID: 168259
		[Token(Token = "0x4029143")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _processor;
	}
}
