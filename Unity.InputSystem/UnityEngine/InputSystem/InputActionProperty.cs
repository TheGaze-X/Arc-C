using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	[Serializable]
	public struct InputActionProperty : IEquatable<InputActionProperty>, IEquatable<InputAction>, IEquatable<InputActionReference>
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000D0")]
		public InputAction action
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x55E8F10", Offset = "0x55E7B10", VA = "0x1855E8F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000D1")]
		public InputActionReference reference
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x55E8FA0", Offset = "0x55E7BA0", VA = "0x1855E8FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000D2")]
		internal InputAction serializedAction
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000D3")]
		internal InputActionReference serializedReference
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x55E8EA0", Offset = "0x55E7AA0", VA = "0x1855E8EA0")]
		public InputActionProperty(InputAction action)
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x55E8ED0", Offset = "0x55E7AD0", VA = "0x1855E8ED0")]
		public InputActionProperty(InputActionReference reference)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x55E8BA0", Offset = "0x55E77A0", VA = "0x1855E8BA0", Slot = "4")]
		public bool Equals(InputActionProperty other)
		{
			return default(bool);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x55E8D70", Offset = "0x55E7970", VA = "0x1855E8D70", Slot = "5")]
		public bool Equals(InputAction other)
		{
			return default(bool);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x55E8D90", Offset = "0x55E7990", VA = "0x1855E8D90", Slot = "6")]
		public bool Equals(InputActionReference other)
		{
			return default(bool);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x55E8C50", Offset = "0x55E7850", VA = "0x1855E8C50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x55E8DF0", Offset = "0x55E79F0", VA = "0x1855E8DF0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x55E8FB0", Offset = "0x55E7BB0", VA = "0x1855E8FB0")]
		public static bool operator ==(InputActionProperty left, InputActionProperty right)
		{
			return default(bool);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x55E9050", Offset = "0x55E7C50", VA = "0x1855E9050")]
		public static bool operator !=(InputActionProperty left, InputActionProperty right)
		{
			return default(bool);
		}

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool m_UseReference;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private InputAction m_Action;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private InputActionReference m_Reference;
	}
}
