using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public class InputActionReference : ScriptableObject
	{
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000D4")]
		public InputActionAsset asset
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000D5")]
		public InputAction action
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x55E9D00", Offset = "0x55E8900", VA = "0x1855E9D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x55E9500", Offset = "0x55E8100", VA = "0x1855E9500")]
		public void Set(InputAction action)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x55E9630", Offset = "0x55E8230", VA = "0x1855E9630")]
		public void Set(InputActionAsset asset, string mapName, string actionName)
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x55E9300", Offset = "0x55E7F00", VA = "0x1855E9300")]
		private void SetInternal(InputActionAsset asset, InputAction action)
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x55E9A00", Offset = "0x55E8600", VA = "0x1855E9A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x55E9240", Offset = "0x55E7E40", VA = "0x1855E9240")]
		private static string GetDisplayName(InputAction action)
		{
			return null;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x55E9910", Offset = "0x55E8510", VA = "0x1855E9910")]
		internal string ToDisplayName()
		{
			return null;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x55E9DE0", Offset = "0x55E89E0", VA = "0x1855E9DE0")]
		public static implicit operator InputAction(InputActionReference reference)
		{
			return null;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x55E90F0", Offset = "0x55E7CF0", VA = "0x1855E90F0")]
		public static InputActionReference Create(InputAction action)
		{
			return null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x55E99F0", Offset = "0x55E85F0", VA = "0x1855E99F0")]
		public InputAction ToInputAction()
		{
			return null;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public InputActionReference()
		{
		}

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal InputActionAsset m_Asset;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal string m_ActionId;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private InputAction m_Action;
	}
}
