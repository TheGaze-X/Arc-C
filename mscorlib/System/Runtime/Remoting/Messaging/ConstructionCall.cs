using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003C8 RID: 968
	[Token(Token = "0x20003C8")]
	[System.CLSCompliant(false)]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class ConstructionCall : MethodCall, System.Runtime.Remoting.Activation.IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage
	{
		// Token: 0x06001E8D RID: 7821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8D")]
		[Address(RVA = "0x4B77FD0", Offset = "0x4B76BD0", VA = "0x184B77FD0")]
		internal ConstructionCall(System.Type type)
		{
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8E")]
		[Address(RVA = "0x4B77F10", Offset = "0x4B76B10", VA = "0x184B77F10")]
		internal ConstructionCall(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8F")]
		[Address(RVA = "0x4B77A80", Offset = "0x4B76680", VA = "0x184B77A80", Slot = "22")]
		internal override void InitDictionary()
		{
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x00012F00 File Offset: 0x00011100
		// (set) Token: 0x06001E91 RID: 7825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B5")]
		internal bool IsContextOk
		{
			[Token(Token = "0x6001E90")]
			[Address(RVA = "0x22032F0", Offset = "0x2201EF0", VA = "0x1822032F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E91")]
			[Address(RVA = "0x2203A90", Offset = "0x2202690", VA = "0x182203A90")]
			set
			{
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003B6")]
		public System.Type ActivationType
		{
			[Token(Token = "0x6001E92")]
			[Address(RVA = "0x4B78050", Offset = "0x4B76C50", VA = "0x184B78050", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003B7")]
		public string ActivationTypeName
		{
			[Token(Token = "0x6001E93")]
			[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B8")]
		public System.Runtime.Remoting.Activation.IActivator Activator
		{
			[Token(Token = "0x6001E94")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10", Slot = "26")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E95")]
			[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0", Slot = "27")]
			set
			{
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003B9")]
		public object[] CallSiteActivationAttributes
		{
			[Token(Token = "0x6001E96")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E97")]
		[Address(RVA = "0x2203A80", Offset = "0x2202680", VA = "0x182203A80")]
		internal void SetActivationAttributes(object[] attributes)
		{
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003BA")]
		public System.Collections.IList ContextProperties
		{
			[Token(Token = "0x6001E98")]
			[Address(RVA = "0x4B78120", Offset = "0x4B76D20", VA = "0x184B78120", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E99")]
		[Address(RVA = "0x4B77BB0", Offset = "0x4B767B0", VA = "0x184B77BB0", Slot = "19")]
		internal override void InitMethodProperty(string key, object value)
		{
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0x4B77940", Offset = "0x4B76540", VA = "0x184B77940", Slot = "20")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001E9B RID: 7835 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003BB")]
		public override System.Collections.IDictionary Properties
		{
			[Token(Token = "0x6001E9B")]
			[Address(RVA = "0x4B781A0", Offset = "0x4B76DA0", VA = "0x184B781A0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001E9D RID: 7837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BC")]
		internal RemotingProxy SourceProxy
		{
			[Token(Token = "0x6001E9C")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E9D")]
			[Address(RVA = "0xF93850", Offset = "0xF92450", VA = "0x180F93850")]
			set
			{
			}
		}

		// Token: 0x0400103E RID: 4158
		[Token(Token = "0x400103E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private System.Runtime.Remoting.Activation.IActivator _activator;

		// Token: 0x0400103F RID: 4159
		[Token(Token = "0x400103F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private object[] _activationAttributes;

		// Token: 0x04001040 RID: 4160
		[Token(Token = "0x4001040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private System.Collections.IList _contextProperties;

		// Token: 0x04001041 RID: 4161
		[Token(Token = "0x4001041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private System.Type _activationType;

		// Token: 0x04001042 RID: 4162
		[Token(Token = "0x4001042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string _activationTypeName;

		// Token: 0x04001043 RID: 4163
		[Token(Token = "0x4001043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool _isContextOk;

		// Token: 0x04001044 RID: 4164
		[Token(Token = "0x4001044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[System.NonSerialized]
		private RemotingProxy _sourceProxy;
	}
}
