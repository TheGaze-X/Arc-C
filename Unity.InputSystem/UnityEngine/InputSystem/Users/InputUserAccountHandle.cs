using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Users
{
	// Token: 0x02000109 RID: 265
	[Token(Token = "0x2000109")]
	public struct InputUserAccountHandle : IEquatable<InputUserAccountHandle>
	{
		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700034D")]
		public string apiName
		{
			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00006348 File Offset: 0x00004548
		[Token(Token = "0x1700034E")]
		public ulong handle
		{
			[Token(Token = "0x6000CAC")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x56C5890", Offset = "0x56C4490", VA = "0x1856C5890")]
		public InputUserAccountHandle(string apiName, ulong handle)
		{
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x56C57D0", Offset = "0x56C43D0", VA = "0x1856C57D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00006360 File Offset: 0x00004560
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x56C55B0", Offset = "0x56C41B0", VA = "0x1856C55B0", Slot = "4")]
		public bool Equals(InputUserAccountHandle other)
		{
			return default(bool);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00006378 File Offset: 0x00004578
		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x56C5650", Offset = "0x56C4250", VA = "0x1856C5650", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00006390 File Offset: 0x00004590
		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x56C5930", Offset = "0x56C4530", VA = "0x1856C5930")]
		public static bool operator ==(InputUserAccountHandle left, InputUserAccountHandle right)
		{
			return default(bool);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x000063A8 File Offset: 0x000045A8
		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x56C59D0", Offset = "0x56C45D0", VA = "0x1856C59D0")]
		public static bool operator !=(InputUserAccountHandle left, InputUserAccountHandle right)
		{
			return default(bool);
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x000063C0 File Offset: 0x000045C0
		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x56C5760", Offset = "0x56C4360", VA = "0x1856C5760", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040005E5 RID: 1509
		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x0")]
		private string m_ApiName;

		// Token: 0x040005E6 RID: 1510
		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x8")]
		private ulong m_Handle;
	}
}
