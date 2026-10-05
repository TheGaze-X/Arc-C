using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000296 RID: 662
	[Token(Token = "0x2000296")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Export/Director/PlayableOutputHandle.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle>
	{
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x000078F0 File Offset: 0x00005AF0
		[Token(Token = "0x170002FD")]
		public static PlayableOutputHandle Null
		{
			[Token(Token = "0x6000F3C")]
			[Address(RVA = "0x5984880", Offset = "0x5983480", VA = "0x185984880")]
			get
			{
				return default(PlayableOutputHandle);
			}
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00007908 File Offset: 0x00005B08
		[Token(Token = "0x6000F3D")]
		[VisibleToOtherModules]
		internal bool IsPlayableOutputOfType<T>()
		{
			return default(bool);
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00007920 File Offset: 0x00005B20
		[Token(Token = "0x6000F3E")]
		[Address(RVA = "0x59827F0", Offset = "0x59813F0", VA = "0x1859827F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00007938 File Offset: 0x00005B38
		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0x59848E0", Offset = "0x59834E0", VA = "0x1859848E0")]
		public static bool operator ==(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			return default(bool);
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00007950 File Offset: 0x00005B50
		[Token(Token = "0x6000F40")]
		[Address(RVA = "0x5983F60", Offset = "0x5982B60", VA = "0x185983F60", Slot = "0")]
		public override bool Equals(object p)
		{
			return default(bool);
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00007968 File Offset: 0x00005B68
		[Token(Token = "0x6000F41")]
		[Address(RVA = "0x5984060", Offset = "0x5982C60", VA = "0x185984060", Slot = "4")]
		public bool Equals(PlayableOutputHandle other)
		{
			return default(bool);
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00007980 File Offset: 0x00005B80
		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x5982490", Offset = "0x5981090", VA = "0x185982490")]
		internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			return default(bool);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00007998 File Offset: 0x00005B98
		[Token(Token = "0x6000F43")]
		[Address(RVA = "0x5984360", Offset = "0x5982F60", VA = "0x185984360")]
		[VisibleToOtherModules]
		internal bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x5984130", Offset = "0x5982D30", VA = "0x185984130")]
		[FreeFunction("PlayableOutputHandleBindings::GetPlayableOutputType", HasExplicitThis = true, ThrowsException = true)]
		internal Type GetPlayableOutputType()
		{
			return null;
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F45")]
		[Address(RVA = "0x5984530", Offset = "0x5983130", VA = "0x185984530")]
		[FreeFunction("PlayableOutputHandleBindings::SetReferenceObject", HasExplicitThis = true, ThrowsException = true)]
		internal void SetReferenceObject(Object target)
		{
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F46")]
		[Address(RVA = "0x59846F0", Offset = "0x59832F0", VA = "0x1859846F0")]
		[FreeFunction("PlayableOutputHandleBindings::SetUserData", HasExplicitThis = true, ThrowsException = true)]
		internal void SetUserData([Writable] Object target)
		{
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x000079B0 File Offset: 0x00005BB0
		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x59842A0", Offset = "0x5982EA0", VA = "0x1859842A0")]
		[FreeFunction("PlayableOutputHandleBindings::GetSourcePlayable", HasExplicitThis = true, ThrowsException = true)]
		internal PlayableHandle GetSourcePlayable()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F48")]
		[Address(RVA = "0x5984610", Offset = "0x5983210", VA = "0x185984610")]
		[FreeFunction("PlayableOutputHandleBindings::SetSourcePlayable", HasExplicitThis = true, ThrowsException = true)]
		internal void SetSourcePlayable(PlayableHandle target, int port)
		{
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x000079C8 File Offset: 0x00005BC8
		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x59841E0", Offset = "0x5982DE0", VA = "0x1859841E0")]
		[FreeFunction("PlayableOutputHandleBindings::GetSourceOutputPort", HasExplicitThis = true, ThrowsException = true)]
		internal int GetSourceOutputPort()
		{
			return 0;
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0x59847C0", Offset = "0x59833C0", VA = "0x1859847C0")]
		[FreeFunction("PlayableOutputHandleBindings::SetWeight", HasExplicitThis = true, ThrowsException = true)]
		internal void SetWeight(float weight)
		{
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0x5984440", Offset = "0x5983040", VA = "0x185984440")]
		[FreeFunction("PlayableOutputHandleBindings::PushNotification", HasExplicitThis = true, ThrowsException = true)]
		internal void PushNotification(PlayableHandle origin, INotification notification, object context)
		{
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0x5983EE0", Offset = "0x5982AE0", VA = "0x185983EE0")]
		[FreeFunction("PlayableOutputHandleBindings::AddNotificationReceiver", HasExplicitThis = true, ThrowsException = true)]
		internal void AddNotificationReceiver(INotificationReceiver receiver)
		{
		}

		// Token: 0x06000F4E RID: 3918
		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0x5984320", Offset = "0x5982F20", VA = "0x185984320")]
		[MethodImpl(4096)]
		private static extern bool IsValid_Injected(ref PlayableOutputHandle _unity_self);

		// Token: 0x06000F4F RID: 3919
		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0x59840F0", Offset = "0x5982CF0", VA = "0x1859840F0")]
		[MethodImpl(4096)]
		private static extern Type GetPlayableOutputType_Injected(ref PlayableOutputHandle _unity_self);

		// Token: 0x06000F50 RID: 3920
		[Token(Token = "0x6000F50")]
		[Address(RVA = "0x59844E0", Offset = "0x59830E0", VA = "0x1859844E0")]
		[MethodImpl(4096)]
		private static extern void SetReferenceObject_Injected(ref PlayableOutputHandle _unity_self, Object target);

		// Token: 0x06000F51 RID: 3921
		[Token(Token = "0x6000F51")]
		[Address(RVA = "0x59846A0", Offset = "0x59832A0", VA = "0x1859846A0")]
		[MethodImpl(4096)]
		private static extern void SetUserData_Injected(ref PlayableOutputHandle _unity_self, [Writable] Object target);

		// Token: 0x06000F52 RID: 3922
		[Token(Token = "0x6000F52")]
		[Address(RVA = "0x5984250", Offset = "0x5982E50", VA = "0x185984250")]
		[MethodImpl(4096)]
		private static extern void GetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, out PlayableHandle ret);

		// Token: 0x06000F53 RID: 3923
		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x59845B0", Offset = "0x59831B0", VA = "0x1859845B0")]
		[MethodImpl(4096)]
		private static extern void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle target, int port);

		// Token: 0x06000F54 RID: 3924
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x59841A0", Offset = "0x5982DA0", VA = "0x1859841A0")]
		[MethodImpl(4096)]
		private static extern int GetSourceOutputPort_Injected(ref PlayableOutputHandle _unity_self);

		// Token: 0x06000F55 RID: 3925
		[Token(Token = "0x6000F55")]
		[Address(RVA = "0x5984770", Offset = "0x5983370", VA = "0x185984770")]
		[MethodImpl(4096)]
		private static extern void SetWeight_Injected(ref PlayableOutputHandle _unity_self, float weight);

		// Token: 0x06000F56 RID: 3926
		[Token(Token = "0x6000F56")]
		[Address(RVA = "0x59843D0", Offset = "0x5982FD0", VA = "0x1859843D0")]
		[MethodImpl(4096)]
		private static extern void PushNotification_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle origin, INotification notification, object context);

		// Token: 0x06000F57 RID: 3927
		[Token(Token = "0x6000F57")]
		[Address(RVA = "0x5983E90", Offset = "0x5982A90", VA = "0x185983E90")]
		[MethodImpl(4096)]
		private static extern void AddNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver);

		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x4000803")]
		[FieldOffset(Offset = "0x0")]
		internal IntPtr m_Handle;

		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		[FieldOffset(Offset = "0x8")]
		internal uint m_Version;

		// Token: 0x04000805 RID: 2053
		[Token(Token = "0x4000805")]
		[FieldOffset(Offset = "0x0")]
		private static readonly PlayableOutputHandle m_Null;
	}
}
