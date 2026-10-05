using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x0200038A RID: 906
	[Token(Token = "0x200038A")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[StructLayout(0)]
	public class Context
	{
		// Token: 0x06001D87 RID: 7559
		[Token(Token = "0x6001D87")]
		[Address(RVA = "0x4B7A180", Offset = "0x4B78D80", VA = "0x184B7A180")]
		[MethodImpl(4096)]
		private static extern void RegisterContext(Context ctx);

		// Token: 0x06001D88 RID: 7560
		[Token(Token = "0x6001D88")]
		[Address(RVA = "0x4B7A3B0", Offset = "0x4B78FB0", VA = "0x184B7A3B0")]
		[MethodImpl(4096)]
		private static extern void ReleaseContext(Context ctx);

		// Token: 0x06001D89 RID: 7561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D89")]
		[Address(RVA = "0x4B7A8B0", Offset = "0x4B794B0", VA = "0x184B7A8B0")]
		public Context()
		{
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8A")]
		[Address(RVA = "0x4B79560", Offset = "0x4B78160", VA = "0x184B79560", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700036D")]
		public static Context DefaultContext
		{
			[Token(Token = "0x6001D8B")]
			[Address(RVA = "0x4AF0AE0", Offset = "0x4AEF6E0", VA = "0x184AF0AE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x00012B70 File Offset: 0x00010D70
		[Token(Token = "0x1700036E")]
		public virtual int ContextID
		{
			[Token(Token = "0x6001D8C")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700036F")]
		public virtual IContextProperty[] ContextProperties
		{
			[Token(Token = "0x6001D8D")]
			[Address(RVA = "0x4B7A930", Offset = "0x4B79530", VA = "0x184B7A930", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x00012B88 File Offset: 0x00010D88
		[Token(Token = "0x17000370")]
		internal bool IsDefaultContext
		{
			[Token(Token = "0x6001D8E")]
			[Address(RVA = "0x1329570", Offset = "0x1328170", VA = "0x181329570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x00012BA0 File Offset: 0x00010DA0
		[Token(Token = "0x17000371")]
		internal bool NeedsContextSink
		{
			[Token(Token = "0x6001D8F")]
			[Address(RVA = "0x4B7AD40", Offset = "0x4B79940", VA = "0x184B7AD40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00012BB8 File Offset: 0x00010DB8
		[Token(Token = "0x6001D90")]
		[Address(RVA = "0x4B7A190", Offset = "0x4B78D90", VA = "0x184B7A190")]
		public static bool RegisterDynamicProperty(IDynamicProperty prop, System.ContextBoundObject obj, Context ctx)
		{
			return default(bool);
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00012BD0 File Offset: 0x00010DD0
		[Token(Token = "0x6001D91")]
		[Address(RVA = "0x4B7A600", Offset = "0x4B79200", VA = "0x184B7A600")]
		public static bool UnregisterDynamicProperty(string name, System.ContextBoundObject obj, Context ctx)
		{
			return default(bool);
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D92")]
		[Address(RVA = "0x4B79A10", Offset = "0x4B78610", VA = "0x184B79A10")]
		private static DynamicPropertyCollection GetDynamicPropertyCollection(System.ContextBoundObject obj, Context ctx)
		{
			return null;
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D93")]
		[Address(RVA = "0x4B7A030", Offset = "0x4B78C30", VA = "0x184B7A030")]
		internal static void NotifyGlobalDynamicSinks(bool start, System.Runtime.Remoting.Messaging.IMessage req_msg, bool client_site, bool async)
		{
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x00012BE8 File Offset: 0x00010DE8
		[Token(Token = "0x17000372")]
		internal static bool HasGlobalDynamicSinks
		{
			[Token(Token = "0x6001D94")]
			[Address(RVA = "0x4B7AB10", Offset = "0x4B79710", VA = "0x184B7AB10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D95")]
		[Address(RVA = "0x4B79F70", Offset = "0x4B78B70", VA = "0x184B79F70")]
		internal void NotifyDynamicSinks(bool start, System.Runtime.Remoting.Messaging.IMessage req_msg, bool client_site, bool async)
		{
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x00012C00 File Offset: 0x00010E00
		[Token(Token = "0x17000373")]
		internal bool HasDynamicSinks
		{
			[Token(Token = "0x6001D96")]
			[Address(RVA = "0x4B7A990", Offset = "0x4B79590", VA = "0x184B7A990")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x00012C18 File Offset: 0x00010E18
		[Token(Token = "0x17000374")]
		internal bool HasExitSinks
		{
			[Token(Token = "0x6001D97")]
			[Address(RVA = "0x4B7A9F0", Offset = "0x4B795F0", VA = "0x184B7A9F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D98")]
		[Address(RVA = "0x4B79C50", Offset = "0x4B78850", VA = "0x184B79C50", Slot = "6")]
		public virtual IContextProperty GetProperty(string name)
		{
			return null;
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D99")]
		[Address(RVA = "0x4B7A410", Offset = "0x4B79010", VA = "0x184B7A410", Slot = "7")]
		public virtual void SetProperty(IContextProperty prop)
		{
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9A")]
		[Address(RVA = "0x4B79660", Offset = "0x4B78260", VA = "0x184B79660", Slot = "8")]
		public virtual void Freeze()
		{
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D9B")]
		[Address(RVA = "0x4B7A5B0", Offset = "0x4B791B0", VA = "0x184B7A5B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D9C")]
		[Address(RVA = "0x4B79DC0", Offset = "0x4B789C0", VA = "0x184B79DC0")]
		internal System.Runtime.Remoting.Messaging.IMessageSink GetServerContextSinkChain()
		{
			return null;
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D9D")]
		[Address(RVA = "0x4B79820", Offset = "0x4B78420", VA = "0x184B79820")]
		internal System.Runtime.Remoting.Messaging.IMessageSink GetClientContextSinkChain()
		{
			return null;
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D9E")]
		[Address(RVA = "0x4B79290", Offset = "0x4B77E90", VA = "0x184B79290")]
		internal System.Runtime.Remoting.Messaging.IMessageSink CreateServerObjectSinkChain(System.MarshalByRefObject obj, bool forceInternalExecute)
		{
			return null;
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D9F")]
		[Address(RVA = "0x4B78980", Offset = "0x4B77580", VA = "0x184B78980")]
		internal System.Runtime.Remoting.Messaging.IMessageSink CreateEnvoySink(System.MarshalByRefObject serverObject)
		{
			return null;
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DA0")]
		[Address(RVA = "0x4B7A5A0", Offset = "0x4B791A0", VA = "0x184B7A5A0")]
		internal static Context SwitchToContext(Context newContext)
		{
			return null;
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DA1")]
		[Address(RVA = "0x4B78B10", Offset = "0x4B77710", VA = "0x184B78B10")]
		internal static Context CreateNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage msg)
		{
			return null;
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA2")]
		[Address(RVA = "0x4B79410", Offset = "0x4B78010", VA = "0x184B79410")]
		public void DoCallBack(CrossContextDelegate deleg)
		{
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000375")]
		private LocalDataStore MyLocalStore
		{
			[Token(Token = "0x6001DA3")]
			[Address(RVA = "0x4B7ABD0", Offset = "0x4B797D0", VA = "0x184B7ABD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DA4")]
		[Address(RVA = "0x4B788B0", Offset = "0x4B774B0", VA = "0x184B788B0")]
		public static System.LocalDataStoreSlot AllocateDataSlot()
		{
			return null;
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DA5")]
		[Address(RVA = "0x4B78910", Offset = "0x4B77510", VA = "0x184B78910")]
		public static System.LocalDataStoreSlot AllocateNamedDataSlot(string name)
		{
			return null;
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA6")]
		[Address(RVA = "0x4B795F0", Offset = "0x4B781F0", VA = "0x184B795F0")]
		public static void FreeNamedDataSlot(string name)
		{
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DA7")]
		[Address(RVA = "0x4B79BE0", Offset = "0x4B787E0", VA = "0x184B79BE0")]
		public static System.LocalDataStoreSlot GetNamedDataSlot(string name)
		{
			return null;
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DA8")]
		[Address(RVA = "0x4B799D0", Offset = "0x4B785D0", VA = "0x184B799D0")]
		public static object GetData(System.LocalDataStoreSlot slot)
		{
			return null;
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA9")]
		[Address(RVA = "0x4B7A3C0", Offset = "0x4B78FC0", VA = "0x184B7A3C0")]
		public static void SetData(System.LocalDataStoreSlot slot, object data)
		{
		}

		// Token: 0x04000FC6 RID: 4038
		[Token(Token = "0x4000FC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int domain_id;

		// Token: 0x04000FC7 RID: 4039
		[Token(Token = "0x4000FC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int context_id;

		// Token: 0x04000FC8 RID: 4040
		[Token(Token = "0x4000FC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.UIntPtr static_data;

		// Token: 0x04000FC9 RID: 4041
		[Token(Token = "0x4000FC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.UIntPtr data;

		// Token: 0x04000FCA RID: 4042
		[Token(Token = "0x4000FCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[System.ContextStatic]
		private static object[] local_slots;

		// Token: 0x04000FCB RID: 4043
		[Token(Token = "0x4000FCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static System.Runtime.Remoting.Messaging.IMessageSink default_server_context_sink;

		// Token: 0x04000FCC RID: 4044
		[Token(Token = "0x4000FCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.Runtime.Remoting.Messaging.IMessageSink server_context_sink_chain;

		// Token: 0x04000FCD RID: 4045
		[Token(Token = "0x4000FCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private System.Runtime.Remoting.Messaging.IMessageSink client_context_sink_chain;

		// Token: 0x04000FCE RID: 4046
		[Token(Token = "0x4000FCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private System.Collections.Generic.List<IContextProperty> context_properties;

		// Token: 0x04000FCF RID: 4047
		[Token(Token = "0x4000FCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static int global_count;

		// Token: 0x04000FD0 RID: 4048
		[Token(Token = "0x4000FD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private LocalDataStoreHolder _localDataStore;

		// Token: 0x04000FD1 RID: 4049
		[Token(Token = "0x4000FD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static LocalDataStoreMgr _localDataStoreMgr;

		// Token: 0x04000FD2 RID: 4050
		[Token(Token = "0x4000FD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DynamicPropertyCollection global_dynamic_properties;

		// Token: 0x04000FD3 RID: 4051
		[Token(Token = "0x4000FD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DynamicPropertyCollection context_dynamic_properties;

		// Token: 0x04000FD4 RID: 4052
		[Token(Token = "0x4000FD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ContextCallbackObject callback_object;
	}
}
