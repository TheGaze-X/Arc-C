using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.SubsystemsImplementation
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
	public static class SubsystemDescriptorStore
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x59CC430", Offset = "0x59CB030", VA = "0x1859CC430")]
		[RequiredByNativeCode]
		internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x59CC280", Offset = "0x59CAE80", VA = "0x1859CC280")]
		[RequiredByNativeCode]
		internal static void ClearManagedDescriptors()
		{
		}

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x59CC530", Offset = "0x59CB130", VA = "0x1859CC530")]
		[MethodImpl(4096)]
		private static extern void ReportSingleSubsystemAnalytics(string id);

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		internal static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, List<TBaseTypeInList> storeInList) where TDescriptor : TBaseTypeInList where TBaseTypeInList : ISubsystemDescriptor
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x59CC4C0", Offset = "0x59CB0C0", VA = "0x1859CC4C0")]
		internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor)
		{
		}

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x8")]
		private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x10")]
		private static List<SubsystemDescriptor> s_DeprecatedDescriptors;
	}
}
