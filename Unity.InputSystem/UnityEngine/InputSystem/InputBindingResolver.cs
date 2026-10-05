using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	internal struct InputBindingResolver : IDisposable
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x1700013E")]
		public int totalMapCount
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x1700013F")]
		public int totalActionCount
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x17000140")]
		public int totalBindingCount
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x17000141")]
		public int totalControlCount
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x561E0A0", Offset = "0x561CCA0", VA = "0x18561E0A0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x561E450", Offset = "0x561D050", VA = "0x18561E450")]
		public void StartWithPreviousResolve(InputActionState state, bool isFullResolve)
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x561BD00", Offset = "0x561A900", VA = "0x18561BD00")]
		public void AddActionMap(InputActionMap actionMap)
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x600042B")]
		private int InstantiateWithParameters<TType>(TypeTable registrations, string namesAndParameters, ref TType[] array, ref int count, InputActionMap actionMap, ref InputBinding binding)
		{
			return 0;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x561E0B0", Offset = "0x561CCB0", VA = "0x18561E0B0")]
		private static InputBindingComposite InstantiateBindingComposite(ref InputBinding binding, InputActionMap actionMap)
		{
			return null;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x561D690", Offset = "0x561C290", VA = "0x18561D690")]
		private static void ApplyParameters(ReadOnlyArray<NamedValue> parameters, object instance, InputActionMap actionMap, ref InputBinding binding, string objectRegistrationName, string namesAndParameters)
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x561DDD0", Offset = "0x561C9D0", VA = "0x18561DDD0")]
		private static int AssignCompositePartIndex(object composite, string name, ref int currentCompositePartCount)
		{
			return 0;
		}

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x0")]
		public int totalProcessorCount;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x4")]
		public int totalCompositeCount;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x8")]
		public int totalInteractionCount;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x10")]
		public InputActionMap[] maps;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x18")]
		public InputControl[] controls;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x20")]
		public InputActionState.UnmanagedMemory memory;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0xA0")]
		public IInputInteraction[] interactions;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0xA8")]
		public InputProcessor[] processors;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0xB0")]
		public InputBindingComposite[] composites;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0xB8")]
		public InputBinding? bindingMask;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x118")]
		private bool m_IsControlOnlyResolve;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x120")]
		private List<NameAndParameters> m_Parameters;
	}
}
