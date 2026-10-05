using System;
using System.Collections;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002C4 RID: 708
	[Token(Token = "0x20002C4")]
	[DefaultMember("Item")]
	[ComVisible(true)]
	[Serializable]
	public class WebHeaderCollection : NameValueCollection, ISerializable
	{
		// Token: 0x06001397 RID: 5015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001397")]
		[Address(RVA = "0x5061D30", Offset = "0x5060930", VA = "0x185061D30")]
		private void NormalizeCommonHeaders()
		{
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000417")]
		private NameValueCollection InnerCollection
		{
			[Token(Token = "0x6001398")]
			[Address(RVA = "0x5063630", Offset = "0x5062230", VA = "0x185063630")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00009660 File Offset: 0x00007860
		[Token(Token = "0x6001399")]
		[Address(RVA = "0x50609D0", Offset = "0x505F5D0", VA = "0x1850609D0")]
		internal static bool AllowMultiValues(string name)
		{
			return default(bool);
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00009678 File Offset: 0x00007878
		[Token(Token = "0x17000418")]
		private bool AllowHttpRequestHeader
		{
			[Token(Token = "0x600139A")]
			[Address(RVA = "0x50635A0", Offset = "0x50621A0", VA = "0x1850635A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600139B")]
		[Address(RVA = "0x5061EE0", Offset = "0x5060AE0", VA = "0x185061EE0")]
		public void Remove(HttpRequestHeader header)
		{
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600139C")]
		[Address(RVA = "0x5060470", Offset = "0x505F070", VA = "0x185060470")]
		internal void AddInternal(string name, string value)
		{
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600139D")]
		[Address(RVA = "0x5060A70", Offset = "0x505F670", VA = "0x185060A70")]
		internal void ChangeInternal(string name, string value)
		{
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600139E")]
		[Address(RVA = "0x5061E70", Offset = "0x5060A70", VA = "0x185061E70")]
		internal void RemoveInternal(string name)
		{
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139F")]
		[Address(RVA = "0x5060AF0", Offset = "0x505F6F0", VA = "0x185060AF0")]
		internal static string CheckBadChars(string name, bool isHeaderValue)
		{
			return null;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00009690 File Offset: 0x00007890
		[Token(Token = "0x60013A0")]
		[Address(RVA = "0x50610B0", Offset = "0x505FCB0", VA = "0x1850610B0")]
		internal static bool ContainsNonAsciiChars(string token)
		{
			return default(bool);
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A1")]
		[Address(RVA = "0x5062660", Offset = "0x5061260", VA = "0x185062660")]
		internal void ThrowOnRestrictedHeader(string headerName)
		{
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A2")]
		[Address(RVA = "0x50604F0", Offset = "0x505F0F0", VA = "0x1850604F0", Slot = "15")]
		public override void Add(string name, string value)
		{
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A3")]
		[Address(RVA = "0x50606D0", Offset = "0x505F2D0", VA = "0x1850606D0")]
		public void Add(string header)
		{
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A4")]
		[Address(RVA = "0x50623A0", Offset = "0x5060FA0", VA = "0x1850623A0", Slot = "18")]
		public override void Set(string name, string value)
		{
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x5062140", Offset = "0x5060D40", VA = "0x185062140")]
		internal void SetInternal(string name, string value)
		{
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A6")]
		[Address(RVA = "0x5061FF0", Offset = "0x5060BF0", VA = "0x185061FF0", Slot = "19")]
		public override void Remove(string name)
		{
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x50616B0", Offset = "0x50602B0", VA = "0x1850616B0", Slot = "17")]
		public override string[] GetValues(string header)
		{
			return null;
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x50628B0", Offset = "0x50614B0", VA = "0x1850628B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A9")]
		[Address(RVA = "0x5061120", Offset = "0x505FD20", VA = "0x185061120")]
		internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace)
		{
			return null;
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013AA")]
		[Address(RVA = "0x5063450", Offset = "0x5062050", VA = "0x185063450")]
		public WebHeaderCollection()
		{
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x50634B0", Offset = "0x50620B0", VA = "0x1850634B0")]
		internal WebHeaderCollection(WebHeaderCollectionType type)
		{
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x5063260", Offset = "0x5061E60", VA = "0x185063260")]
		protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
		public override void OnDeserialization(object sender)
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x50614F0", Offset = "0x50600F0", VA = "0x1850614F0", Slot = "11")]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x5062600", Offset = "0x5061200", VA = "0x185062600", Slot = "9")]
		private void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x5061960", Offset = "0x5060560", VA = "0x185061960", Slot = "16")]
		public override string Get(string name)
		{
			return null;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x5061400", Offset = "0x5060000", VA = "0x185061400", Slot = "13")]
		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x000096A8 File Offset: 0x000078A8
		[Token(Token = "0x17000419")]
		public override int Count
		{
			[Token(Token = "0x60013B2")]
			[Address(RVA = "0x50635D0", Offset = "0x50621D0", VA = "0x1850635D0", Slot = "14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x5061CC0", Offset = "0x50608C0", VA = "0x185061CC0", Slot = "20")]
		public override string Get(int index)
		{
			return null;
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B4")]
		[Address(RVA = "0x50618F0", Offset = "0x50604F0", VA = "0x1850618F0", Slot = "21")]
		public override string[] GetValues(int index)
		{
			return null;
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B5")]
		[Address(RVA = "0x5061480", Offset = "0x5060080", VA = "0x185061480", Slot = "22")]
		public override string GetKey(int index)
		{
			return null;
		}

		// Token: 0x04000A9F RID: 2719
		[Token(Token = "0x4000A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly HeaderInfoTable HInfo;

		// Token: 0x04000AA0 RID: 2720
		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string[] m_CommonHeaders;

		// Token: 0x04000AA1 RID: 2721
		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int m_NumCommonHeaders;

		// Token: 0x04000AA2 RID: 2722
		[Token(Token = "0x4000AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string[] s_CommonHeaderNames;

		// Token: 0x04000AA3 RID: 2723
		[Token(Token = "0x4000AA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly sbyte[] s_CommonHeaderHints;

		// Token: 0x04000AA4 RID: 2724
		[Token(Token = "0x4000AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private NameValueCollection m_InnerCollection;

		// Token: 0x04000AA5 RID: 2725
		[Token(Token = "0x4000AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private WebHeaderCollectionType m_Type;

		// Token: 0x04000AA6 RID: 2726
		[Token(Token = "0x4000AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly char[] HttpTrimCharacters;

		// Token: 0x04000AA7 RID: 2727
		[Token(Token = "0x4000AA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static WebHeaderCollection.RfcChar[] RfcCharMap;

		// Token: 0x020002C5 RID: 709
		[Token(Token = "0x20002C5")]
		private enum RfcChar : byte
		{
			// Token: 0x04000AA9 RID: 2729
			[Token(Token = "0x4000AA9")]
			High,
			// Token: 0x04000AAA RID: 2730
			[Token(Token = "0x4000AAA")]
			Reg,
			// Token: 0x04000AAB RID: 2731
			[Token(Token = "0x4000AAB")]
			Ctl,
			// Token: 0x04000AAC RID: 2732
			[Token(Token = "0x4000AAC")]
			CR,
			// Token: 0x04000AAD RID: 2733
			[Token(Token = "0x4000AAD")]
			LF,
			// Token: 0x04000AAE RID: 2734
			[Token(Token = "0x4000AAE")]
			WS,
			// Token: 0x04000AAF RID: 2735
			[Token(Token = "0x4000AAF")]
			Colon,
			// Token: 0x04000AB0 RID: 2736
			[Token(Token = "0x4000AB0")]
			Delim
		}
	}
}
