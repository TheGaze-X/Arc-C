using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003690 RID: 13968
	[Token(Token = "0x2003690")]
	internal sealed class TransitionManagerImpl : ITransitionManager
	{
		// Token: 0x0601637D RID: 91005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601637D")]
		[Address(RVA = "0xEB5CB0", Offset = "0xEB48B0", VA = "0x180EB5CB0")]
		internal TransitionManagerImpl()
		{
		}

		// Token: 0x0601637E RID: 91006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601637E")]
		[Address(RVA = "0xEB5590", Offset = "0xEB4190", VA = "0x180EB5590", Slot = "4")]
		public Transition FindTransition(Type fromState, Type toState, TransitionType transType, bool reset)
		{
			return null;
		}

		// Token: 0x0601637F RID: 91007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601637F")]
		[Address(RVA = "0xEB5730", Offset = "0xEB4330", VA = "0x180EB5730", Slot = "5")]
		public void PutTransition(Transition transition, Type fromState, Type toState, TransitionType transType)
		{
		}

		// Token: 0x06016380 RID: 91008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016380")]
		[Address(RVA = "0xEB5AB0", Offset = "0xEB46B0", VA = "0x180EB5AB0")]
		private static string _GetTransitionHash(Type fromState, Type toState, TransitionType transType)
		{
			return null;
		}

		// Token: 0x06016381 RID: 91009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016381")]
		[Address(RVA = "0xEB59F0", Offset = "0xEB45F0", VA = "0x180EB59F0")]
		private Transition _GetDefaultTransition()
		{
			return null;
		}

		// Token: 0x06016382 RID: 91010 RVA: 0x00090060 File Offset: 0x0008E260
		[Token(Token = "0x6016382")]
		[Address(RVA = "0xEB5910", Offset = "0xEB4510", VA = "0x180EB5910")]
		internal static bool _CheckWildStateValidation(bool isWildFrom, bool isWildTo, TransitionType transType, out string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x0401AB25 RID: 109349
		[Token(Token = "0x401AB25")]
		private const string STATE_WILDCARD = "#";

		// Token: 0x0401AB26 RID: 109350
		[Token(Token = "0x401AB26")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, Transition> m_transMap;
	}
}
