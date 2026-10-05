using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x0200036E RID: 878
	[Token(Token = "0x200036E")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public static class RemotingServices
	{
		// Token: 0x06001CCB RID: 7371
		[Token(Token = "0x6001CCB")]
		[Address(RVA = "0x4B8C440", Offset = "0x4B8B040", VA = "0x184B8C440")]
		[MethodImpl(4096)]
		internal static extern object InternalExecute(System.Reflection.MethodBase method, object obj, object[] parameters, out object[] out_args);

		// Token: 0x06001CCC RID: 7372
		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x4B8BB30", Offset = "0x4B8A730", VA = "0x184B8BB30")]
		[MethodImpl(4096)]
		internal static extern System.Reflection.MethodBase GetVirtualMethod(System.Type type, System.Reflection.MethodBase method);

		// Token: 0x06001CCD RID: 7373 RVA: 0x000129A8 File Offset: 0x00010BA8
		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x4B8C500", Offset = "0x4B8B100", VA = "0x184B8C500")]
		public static bool IsTransparentProxy(object proxy)
		{
			return default(bool);
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CCE")]
		[Address(RVA = "0x4B8BB40", Offset = "0x4B8A740", VA = "0x184B8BB40")]
		internal static System.Runtime.Remoting.Messaging.IMethodReturnMessage InternalExecuteMessage(System.MarshalByRefObject target, System.Runtime.Remoting.Messaging.IMethodCallMessage reqMsg)
		{
			return null;
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CCF")]
		[Address(RVA = "0x4B88E50", Offset = "0x4B87A50", VA = "0x184B88E50")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static object Connect(System.Type classToProxy, string url)
		{
			return null;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CD0")]
		[Address(RVA = "0x4B88D50", Offset = "0x4B87950", VA = "0x184B88D50")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static object Connect(System.Type classToProxy, string url, object data)
		{
			return null;
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CD1")]
		[Address(RVA = "0x4B8BA70", Offset = "0x4B8A670", VA = "0x184B8BA70")]
		public static System.Type GetServerTypeForUri(string URI)
		{
			return null;
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CD2")]
		[Address(RVA = "0x4B8D230", Offset = "0x4B8BE30", VA = "0x184B8D230")]
		public static object Unmarshal(ObjRef objectRef)
		{
			return null;
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CD3")]
		[Address(RVA = "0x4B8D280", Offset = "0x4B8BE80", VA = "0x184B8D280")]
		public static object Unmarshal(ObjRef objectRef, bool fRefine)
		{
			return null;
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CD4")]
		[Address(RVA = "0x4B8C5D0", Offset = "0x4B8B1D0", VA = "0x184B8C5D0")]
		public static ObjRef Marshal(System.MarshalByRefObject Obj)
		{
			return null;
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CD5")]
		[Address(RVA = "0x4B8C550", Offset = "0x4B8B150", VA = "0x184B8C550")]
		public static ObjRef Marshal(System.MarshalByRefObject Obj, string ObjURI, System.Type RequestedType)
		{
			return null;
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CD6")]
		[Address(RVA = "0x4B8C620", Offset = "0x4B8B220", VA = "0x184B8C620")]
		private static string NewUri()
		{
			return null;
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CD7")]
		[Address(RVA = "0x4B8B9B0", Offset = "0x4B8A5B0", VA = "0x184B8B9B0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static System.Runtime.Remoting.Proxies.RealProxy GetRealProxy(object proxy)
		{
			return null;
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CD8")]
		[Address(RVA = "0x4B8ABC0", Offset = "0x4B897C0", VA = "0x184B8ABC0")]
		public static System.Reflection.MethodBase GetMethodBaseFromMethodMessage(System.Runtime.Remoting.Messaging.IMethodMessage msg)
		{
			return null;
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CD9")]
		[Address(RVA = "0x4B8ADD0", Offset = "0x4B899D0", VA = "0x184B8ADD0")]
		internal static System.Reflection.MethodBase GetMethodBaseFromName(System.Type type, string methodName, System.Type[] signature)
		{
			return null;
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CDA")]
		[Address(RVA = "0x4B8A1E0", Offset = "0x4B88DE0", VA = "0x184B8A1E0")]
		private static System.Reflection.MethodBase FindInterfaceMethod(System.Type type, string methodName, System.Type[] signature)
		{
			return null;
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDB")]
		[Address(RVA = "0x4B8B040", Offset = "0x4B89C40", VA = "0x184B8B040")]
		public static void GetObjectData(object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x000129C0 File Offset: 0x00010BC0
		[Token(Token = "0x6001CDC")]
		[Address(RVA = "0x4B8C450", Offset = "0x4B8B050", VA = "0x184B8C450")]
		public static bool IsOneWay(System.Reflection.MethodBase method)
		{
			return default(bool);
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CDD")]
		[Address(RVA = "0x4B89580", Offset = "0x4B88180", VA = "0x184B89580")]
		internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes)
		{
			return null;
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CDE")]
		[Address(RVA = "0x4B89200", Offset = "0x4B87E00", VA = "0x184B89200")]
		internal static object CreateClientProxy(System.Type objectType, string url, object[] activationAttributes)
		{
			return null;
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CDF")]
		[Address(RVA = "0x4B89450", Offset = "0x4B88050", VA = "0x184B89450")]
		internal static object CreateClientProxy(WellKnownClientTypeEntry entry)
		{
			return null;
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0x4B89000", Offset = "0x4B87C00", VA = "0x184B89000")]
		internal static object CreateClientProxyForContextBound(System.Type type, object[] activationAttributes)
		{
			return null;
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CE1")]
		[Address(RVA = "0x4B8A470", Offset = "0x4B89070", VA = "0x184B8A470")]
		internal static Identity GetIdentityForUri(string uri)
		{
			return null;
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CE2")]
		[Address(RVA = "0x4B8CD00", Offset = "0x4B8B900", VA = "0x184B8CD00")]
		private static string RemoveAppNameFromUri(string uri)
		{
			return null;
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CE3")]
		[Address(RVA = "0x4B8B0F0", Offset = "0x4B89CF0", VA = "0x184B8B0F0")]
		internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, System.Type proxyType, out object clientProxy)
		{
			return null;
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CE4")]
		[Address(RVA = "0x4B8A330", Offset = "0x4B88F30", VA = "0x184B8A330")]
		private static System.Runtime.Remoting.Messaging.IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri)
		{
			return null;
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CE5")]
		[Address(RVA = "0x4B89710", Offset = "0x4B88310", VA = "0x184B89710")]
		internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(System.Type objectType)
		{
			return null;
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CE6")]
		[Address(RVA = "0x4B88F40", Offset = "0x4B87B40", VA = "0x184B88F40")]
		internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(System.MarshalByRefObject realObject, System.Type objectType, string objectUri)
		{
			return null;
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CE7")]
		[Address(RVA = "0x4B89810", Offset = "0x4B88410", VA = "0x184B89810")]
		internal static ServerIdentity CreateWellKnownServerIdentity(System.Type objectType, string objectUri, WellKnownObjectMode mode)
		{
			return null;
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE8")]
		[Address(RVA = "0x4B8CAB0", Offset = "0x4B8B6B0", VA = "0x184B8CAB0")]
		private static void RegisterServerIdentity(ServerIdentity identity)
		{
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CE9")]
		[Address(RVA = "0x4B8B880", Offset = "0x4B8A480", VA = "0x184B8B880")]
		internal static object GetProxyForRemoteObject(ObjRef objref, System.Type classToProxy)
		{
			return null;
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CEA")]
		[Address(RVA = "0x4B8BA00", Offset = "0x4B8A600", VA = "0x184B8BA00")]
		internal static object GetRemoteObject(ObjRef objRef, System.Type proxyType)
		{
			return null;
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CEB")]
		[Address(RVA = "0x4B8CE00", Offset = "0x4B8BA00", VA = "0x184B8CE00")]
		internal static byte[] SerializeCallData(object obj)
		{
			return null;
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CEC")]
		[Address(RVA = "0x4B89930", Offset = "0x4B88530", VA = "0x184B89930")]
		internal static object DeserializeCallData(byte[] array)
		{
			return null;
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CED")]
		[Address(RVA = "0x4B8D080", Offset = "0x4B8BC80", VA = "0x184B8D080")]
		internal static byte[] SerializeExceptionData(System.Exception ex)
		{
			return null;
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CEE")]
		[Address(RVA = "0x4B8CA70", Offset = "0x4B8B670", VA = "0x184B8CA70")]
		private static void RegisterInternalChannels()
		{
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CEF")]
		[Address(RVA = "0x4B89F70", Offset = "0x4B88B70", VA = "0x184B89F70")]
		internal static void DisposeIdentity(Identity ident)
		{
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CF0")]
		[Address(RVA = "0x4B8A840", Offset = "0x4B89440", VA = "0x184B8A840")]
		internal static Identity GetMessageTargetIdentity(System.Runtime.Remoting.Messaging.IMessage msg)
		{
			return null;
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF1")]
		[Address(RVA = "0x4B8D170", Offset = "0x4B8BD70", VA = "0x184B8D170")]
		internal static void SetMessageTargetIdentity(System.Runtime.Remoting.Messaging.IMessage msg, Identity ident)
		{
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x000129D8 File Offset: 0x00010BD8
		[Token(Token = "0x6001CF2")]
		[Address(RVA = "0x4B8D550", Offset = "0x4B8C150", VA = "0x184B8D550")]
		internal static bool UpdateOutArgObject(System.Reflection.ParameterInfo pi, object local, object remote)
		{
			return default(bool);
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CF3")]
		[Address(RVA = "0x4B8AFD0", Offset = "0x4B89BD0", VA = "0x184B8AFD0")]
		private static string GetNormalizedUri(string uri)
		{
			return null;
		}

		// Token: 0x04000F78 RID: 3960
		[Token(Token = "0x4000F78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Collections.Hashtable uri_hash;

		// Token: 0x04000F79 RID: 3961
		[Token(Token = "0x4000F79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static System.Runtime.Serialization.Formatters.Binary.BinaryFormatter _serializationFormatter;

		// Token: 0x04000F7A RID: 3962
		[Token(Token = "0x4000F7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static System.Runtime.Serialization.Formatters.Binary.BinaryFormatter _deserializationFormatter;

		// Token: 0x04000F7B RID: 3963
		[Token(Token = "0x4000F7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string app_id;

		// Token: 0x04000F7C RID: 3964
		[Token(Token = "0x4000F7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly object app_id_lock;

		// Token: 0x04000F7D RID: 3965
		[Token(Token = "0x4000F7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static int next_id;

		// Token: 0x04000F7E RID: 3966
		[Token(Token = "0x4000F7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly System.Reflection.MethodInfo FieldSetterMethod;

		// Token: 0x04000F7F RID: 3967
		[Token(Token = "0x4000F7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly System.Reflection.MethodInfo FieldGetterMethod;

		// Token: 0x0200036F RID: 879
		[Token(Token = "0x200036F")]
		[System.Serializable]
		private class CACD
		{
			// Token: 0x06001CF4 RID: 7412 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001CF4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CACD()
			{
			}

			// Token: 0x04000F80 RID: 3968
			[Token(Token = "0x4000F80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object d;

			// Token: 0x04000F81 RID: 3969
			[Token(Token = "0x4000F81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object c;
		}
	}
}
