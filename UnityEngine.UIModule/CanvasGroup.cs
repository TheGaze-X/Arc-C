using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[NativeHeader("Modules/UI/CanvasGroup.h")]
	[NativeClass("UI::CanvasGroup")]
	public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2
		// (set) Token: 0x06000003 RID: 3
		[Token(Token = "0x17000001")]
		[NativeProperty("Alpha", false, TargetType.Function)]
		public extern float alpha { [Token(Token = "0x6000002")] [Address(RVA = "0x5B51480", Offset = "0x5B50080", VA = "0x185B51480")] [MethodImpl(4096)] get; [Token(Token = "0x6000003")] [Address(RVA = "0x5B51540", Offset = "0x5B50140", VA = "0x185B51540")] [MethodImpl(4096)] set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4
		// (set) Token: 0x06000005 RID: 5
		[Token(Token = "0x17000002")]
		[NativeProperty("Interactable", false, TargetType.Function)]
		public extern bool interactable { [Token(Token = "0x6000004")] [Address(RVA = "0x5B51500", Offset = "0x5B50100", VA = "0x185B51500")] [MethodImpl(4096)] get; [Token(Token = "0x6000005")] [Address(RVA = "0x5B51630", Offset = "0x5B50230", VA = "0x185B51630")] [MethodImpl(4096)] set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6
		// (set) Token: 0x06000007 RID: 7
		[Token(Token = "0x17000003")]
		[NativeProperty("BlocksRaycasts", false, TargetType.Function)]
		public extern bool blocksRaycasts { [Token(Token = "0x6000006")] [Address(RVA = "0x5B51440", Offset = "0x5B50040", VA = "0x185B51440")] [MethodImpl(4096)] get; [Token(Token = "0x6000007")] [Address(RVA = "0x5B51590", Offset = "0x5B50190", VA = "0x185B51590")] [MethodImpl(4096)] set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8
		// (set) Token: 0x06000009 RID: 9
		[Token(Token = "0x17000004")]
		[NativeProperty("IgnoreParentGroups", false, TargetType.Function)]
		public extern bool ignoreParentGroups { [Token(Token = "0x6000008")] [Address(RVA = "0x5B514C0", Offset = "0x5B500C0", VA = "0x185B514C0")] [MethodImpl(4096)] get; [Token(Token = "0x6000009")] [Address(RVA = "0x5B515E0", Offset = "0x5B501E0", VA = "0x185B515E0")] [MethodImpl(4096)] set; }

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x5B51440", Offset = "0x5B50040", VA = "0x185B51440", Slot = "4")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public CanvasGroup()
		{
		}
	}
}
