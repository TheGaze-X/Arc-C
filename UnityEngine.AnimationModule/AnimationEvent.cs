using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[RequiredByNativeCode]
	[Serializable]
	[StructLayout(0)]
	public sealed class AnimationEvent
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x5911B00", Offset = "0x5910700", VA = "0x185911B00")]
		public AnimationEvent()
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public string stringParameter
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x5911BE0", Offset = "0x59107E0", VA = "0x185911BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x17000013")]
		public float floatParameter
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x5911BA0", Offset = "0x59107A0", VA = "0x185911BA0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x17000014")]
		public int intParameter
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x5911BB0", Offset = "0x59107B0", VA = "0x185911BB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000015")]
		public Object objectReferenceParameter
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x5911BD0", Offset = "0x59107D0", VA = "0x185911BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		public string functionName
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x4893C50", Offset = "0x4892850", VA = "0x184893C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002130 File Offset: 0x00000330
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public float time
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x5911BF0", Offset = "0x59107F0", VA = "0x185911BF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x4E65E0", Offset = "0x4E51E0", VA = "0x1804E65E0")]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x17000018")]
		public SendMessageOptions messageOptions
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x5911BC0", Offset = "0x59107C0", VA = "0x185911BC0")]
			get
			{
				return SendMessageOptions.RequireReceiver;
			}
		}

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal float m_Time;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal string m_FunctionName;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal string m_StringParameter;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal Object m_ObjectReferenceParameter;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal float m_FloatParameter;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal int m_IntParameter;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal int m_MessageOptions;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal AnimationEventSource m_Source;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal AnimationState m_StateSender;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal AnimatorStateInfo m_AnimatorStateInfo;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		internal AnimatorClipInfo m_AnimatorClipInfo;
	}
}
