using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	public abstract class InputBindingComposite
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003F3 RID: 1011
		[Token(Token = "0x17000133")]
		public abstract Type valueType { [Token(Token = "0x60003F3")] get; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003F4 RID: 1012
		[Token(Token = "0x17000134")]
		public abstract int valueSizeInBytes { [Token(Token = "0x60003F4")] get; }

		// Token: 0x060003F5 RID: 1013
		[Token(Token = "0x60003F5")]
		public unsafe abstract void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize);

		// Token: 0x060003F6 RID: 1014
		[Token(Token = "0x60003F6")]
		public abstract object ReadValueAsObject(ref InputBindingCompositeContext context);

		// Token: 0x060003F7 RID: 1015 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "8")]
		public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		protected virtual void FinishSetup(ref InputBindingCompositeContext context)
		{
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x55F6D40", Offset = "0x55F5940", VA = "0x1855F6D40")]
		internal void CallFinishSetup(ref InputBindingCompositeContext context)
		{
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x55F70F0", Offset = "0x55F5CF0", VA = "0x1855F70F0")]
		internal static Type GetValueType(string composite)
		{
			return null;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x55F6EA0", Offset = "0x55F5AA0", VA = "0x1855F6EA0")]
		public static string GetExpectedControlLayoutName(string composite, string part)
		{
			return null;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x55F7070", Offset = "0x55F5C70", VA = "0x1855F7070")]
		internal static IEnumerable<string> GetPartNames(string composite)
		{
			return null;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x55F6D90", Offset = "0x55F5990", VA = "0x1855F6D90")]
		internal static string GetDisplayFormatString(string composite)
		{
			return null;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected InputBindingComposite()
		{
		}

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x0")]
		internal static TypeTable s_Composites;
	}
}
