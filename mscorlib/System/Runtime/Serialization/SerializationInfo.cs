using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x02000413 RID: 1043
	[Token(Token = "0x2000413")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class SerializationInfo
	{
		// Token: 0x06002053 RID: 8275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002053")]
		[Address(RVA = "0x4BAEC90", Offset = "0x4BAD890", VA = "0x184BAEC90")]
		[System.CLSCompliant(false)]
		public SerializationInfo(System.Type type, IFormatterConverter converter)
		{
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002054")]
		[Address(RVA = "0x4BAECB0", Offset = "0x4BAD8B0", VA = "0x184BAECB0")]
		[System.CLSCompliant(false)]
		public SerializationInfo(System.Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust)
		{
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000450")]
		public string FullTypeName
		{
			[Token(Token = "0x6002055")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000451")]
		public string AssemblyName
		{
			[Token(Token = "0x6002056")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002057")]
		[Address(RVA = "0x4BAE710", Offset = "0x4BAD310", VA = "0x184BAE710")]
		public void SetType(System.Type type)
		{
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x00013530 File Offset: 0x00011730
		[Token(Token = "0x6002058")]
		[Address(RVA = "0x4BAD230", Offset = "0x4BABE30", VA = "0x184BAD230")]
		private static bool Compare(byte[] a, byte[] b)
		{
			return default(bool);
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002059")]
		[Address(RVA = "0x4BAD2A0", Offset = "0x4BABEA0", VA = "0x184BAD2A0")]
		internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName)
		{
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00013548 File Offset: 0x00011748
		[Token(Token = "0x600205A")]
		[Address(RVA = "0x4BAE580", Offset = "0x4BAD180", VA = "0x184BAE580")]
		internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName)
		{
			return default(bool);
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x00013560 File Offset: 0x00011760
		[Token(Token = "0x17000452")]
		public int MemberCount
		{
			[Token(Token = "0x600205B")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000453")]
		public System.Type ObjectType
		{
			[Token(Token = "0x600205C")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x00013578 File Offset: 0x00011778
		[Token(Token = "0x17000454")]
		public bool IsFullTypeNameSetExplicit
		{
			[Token(Token = "0x600205D")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x00013590 File Offset: 0x00011790
		[Token(Token = "0x17000455")]
		public bool IsAssemblyNameSetExplicit
		{
			[Token(Token = "0x600205E")]
			[Address(RVA = "0x2419850", Offset = "0x2418450", VA = "0x182419850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600205F")]
		[Address(RVA = "0x4BADAD0", Offset = "0x4BAC6D0", VA = "0x184BADAD0")]
		public SerializationInfoEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002060")]
		[Address(RVA = "0x4BAD410", Offset = "0x4BAC010", VA = "0x184BAD410")]
		private void ExpandArrays()
		{
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002061")]
		[Address(RVA = "0x4BAC3B0", Offset = "0x4BAAFB0", VA = "0x184BAC3B0")]
		public void AddValue(string name, object value, System.Type type)
		{
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002062")]
		[Address(RVA = "0x4BAC5F0", Offset = "0x4BAB1F0", VA = "0x184BAC5F0")]
		public void AddValue(string name, object value)
		{
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002063")]
		[Address(RVA = "0x4BAD0C0", Offset = "0x4BABCC0", VA = "0x184BAD0C0")]
		public void AddValue(string name, bool value)
		{
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002064")]
		[Address(RVA = "0x4BAC990", Offset = "0x4BAB590", VA = "0x184BAC990")]
		public void AddValue(string name, byte value)
		{
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002065")]
		[Address(RVA = "0x4BACB00", Offset = "0x4BAB700", VA = "0x184BACB00")]
		public void AddValue(string name, short value)
		{
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002066")]
		[Address(RVA = "0x4BACDE0", Offset = "0x4BAB9E0", VA = "0x184BACDE0")]
		public void AddValue(string name, int value)
		{
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002067")]
		[Address(RVA = "0x4BAC480", Offset = "0x4BAB080", VA = "0x184BAC480")]
		public void AddValue(string name, long value)
		{
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002068")]
		[Address(RVA = "0x4BACF50", Offset = "0x4BABB50", VA = "0x184BACF50")]
		[System.CLSCompliant(false)]
		public void AddValue(string name, ulong value)
		{
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002069")]
		[Address(RVA = "0x4BAC810", Offset = "0x4BAB410", VA = "0x184BAC810")]
		public void AddValue(string name, float value)
		{
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600206A")]
		[Address(RVA = "0x4BACC70", Offset = "0x4BAB870", VA = "0x184BACC70")]
		public void AddValue(string name, System.DateTime value)
		{
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600206B")]
		[Address(RVA = "0x4BAC070", Offset = "0x4BAAC70", VA = "0x184BAC070")]
		internal void AddValueInternal(string name, object value, System.Type type)
		{
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600206C")]
		[Address(RVA = "0x4BAEAC0", Offset = "0x4BAD6C0", VA = "0x184BAEAC0")]
		internal void UpdateValue(string name, object value, System.Type type)
		{
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x000135A8 File Offset: 0x000117A8
		[Token(Token = "0x600206D")]
		[Address(RVA = "0x4BAD540", Offset = "0x4BAC140", VA = "0x184BAD540")]
		private int FindElement(string name)
		{
			return 0;
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600206E")]
		[Address(RVA = "0x4BAD8F0", Offset = "0x4BAC4F0", VA = "0x184BAD8F0")]
		private object GetElement(string name, out System.Type foundType)
		{
			return null;
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600206F")]
		[Address(RVA = "0x4BAD790", Offset = "0x4BAC390", VA = "0x184BAD790")]
		[System.Runtime.InteropServices.ComVisible(true)]
		private object GetElementNoThrow(string name, out System.Type foundType)
		{
			return null;
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002070")]
		[Address(RVA = "0x4BAE390", Offset = "0x4BACF90", VA = "0x184BAE390")]
		public object GetValue(string name, System.Type type)
		{
			return null;
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002071")]
		[Address(RVA = "0x4BAE1B0", Offset = "0x4BACDB0", VA = "0x184BAE1B0")]
		[System.Runtime.InteropServices.ComVisible(true)]
		internal object GetValueNoThrow(string name, System.Type type)
		{
			return null;
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x000135C0 File Offset: 0x000117C0
		[Token(Token = "0x6002072")]
		[Address(RVA = "0x4BAD610", Offset = "0x4BAC210", VA = "0x184BAD610")]
		public bool GetBoolean(string name)
		{
			return default(bool);
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x000135D8 File Offset: 0x000117D8
		[Token(Token = "0x6002073")]
		[Address(RVA = "0x4BADBA0", Offset = "0x4BAC7A0", VA = "0x184BADBA0")]
		public int GetInt32(string name)
		{
			return 0;
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x000135F0 File Offset: 0x000117F0
		[Token(Token = "0x6002074")]
		[Address(RVA = "0x4BADD20", Offset = "0x4BAC920", VA = "0x184BADD20")]
		public long GetInt64(string name)
		{
			return 0L;
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00013608 File Offset: 0x00011808
		[Token(Token = "0x6002075")]
		[Address(RVA = "0x4BADEA0", Offset = "0x4BACAA0", VA = "0x184BADEA0")]
		public float GetSingle(string name)
		{
			return 0f;
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002076")]
		[Address(RVA = "0x4BAE020", Offset = "0x4BACC20", VA = "0x184BAE020")]
		public string GetString(string name)
		{
			return null;
		}

		// Token: 0x040010F2 RID: 4338
		[Token(Token = "0x40010F2")]
		private const int defaultSize = 4;

		// Token: 0x040010F3 RID: 4339
		[Token(Token = "0x40010F3")]
		private const string s_mscorlibAssemblySimpleName = "mscorlib";

		// Token: 0x040010F4 RID: 4340
		[Token(Token = "0x40010F4")]
		private const string s_mscorlibFileName = "mscorlib.dll";

		// Token: 0x040010F5 RID: 4341
		[Token(Token = "0x40010F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal string[] m_members;

		// Token: 0x040010F6 RID: 4342
		[Token(Token = "0x40010F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object[] m_data;

		// Token: 0x040010F7 RID: 4343
		[Token(Token = "0x40010F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal System.Type[] m_types;

		// Token: 0x040010F8 RID: 4344
		[Token(Token = "0x40010F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.Collections.Generic.Dictionary<string, int> m_nameToIndex;

		// Token: 0x040010F9 RID: 4345
		[Token(Token = "0x40010F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal int m_currMember;

		// Token: 0x040010FA RID: 4346
		[Token(Token = "0x40010FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal IFormatterConverter m_converter;

		// Token: 0x040010FB RID: 4347
		[Token(Token = "0x40010FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string m_fullTypeName;

		// Token: 0x040010FC RID: 4348
		[Token(Token = "0x40010FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string m_assemName;

		// Token: 0x040010FD RID: 4349
		[Token(Token = "0x40010FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private System.Type objectType;

		// Token: 0x040010FE RID: 4350
		[Token(Token = "0x40010FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isFullTypeNameSetExplicit;

		// Token: 0x040010FF RID: 4351
		[Token(Token = "0x40010FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool isAssemblyNameSetExplicit;

		// Token: 0x04001100 RID: 4352
		[Token(Token = "0x4001100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool requireSameTokenInPartialTrust;
	}
}
