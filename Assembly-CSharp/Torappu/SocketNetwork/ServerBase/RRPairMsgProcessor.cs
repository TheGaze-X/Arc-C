using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SocketNetwork.ServerBase
{
	// Token: 0x020014C1 RID: 5313
	[Token(Token = "0x20014C1")]
	public class RRPairMsgProcessor : IHotfixable, INetMsgProcessor
	{
		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06007A89 RID: 31369 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A8A RID: 31370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E9C")]
		public IServerLogRule logRule
		{
			[Token(Token = "0x6007A89")]
			[Address(RVA = "0x2646650", Offset = "0x2645250", VA = "0x182646650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007A8A")]
			[Address(RVA = "0x2646710", Offset = "0x2645310", VA = "0x182646710")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06007A8B RID: 31371 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A8C RID: 31372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E9D")]
		public IServerLoadingMask mask
		{
			[Token(Token = "0x6007A8B")]
			[Address(RVA = "0x26466B0", Offset = "0x26452B0", VA = "0x1826466B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007A8C")]
			[Address(RVA = "0x2646790", Offset = "0x2645390", VA = "0x182646790")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06007A8D RID: 31373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A8D")]
		[Address(RVA = "0x26464D0", Offset = "0x26450D0", VA = "0x1826464D0")]
		public RRPairMsgProcessor(INetProtocolSuite protocolSuit)
		{
		}

		// Token: 0x06007A8E RID: 31374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007A8E")]
		[Address(RVA = "0x2645470", Offset = "0x2644070", VA = "0x182645470")]
		public NetMsg TakeRequest(RequestHandler req)
		{
			return null;
		}

		// Token: 0x06007A8F RID: 31375 RVA: 0x00036CC0 File Offset: 0x00034EC0
		[Token(Token = "0x6007A8F")]
		[Address(RVA = "0x26450D0", Offset = "0x2643CD0", VA = "0x1826450D0", Slot = "4")]
		public bool ProcMsg(NetMsg msg)
		{
			return default(bool);
		}

		// Token: 0x06007A90 RID: 31376 RVA: 0x00036CD8 File Offset: 0x00034ED8
		[Token(Token = "0x6007A90")]
		[Address(RVA = "0x2644FA0", Offset = "0x2643BA0", VA = "0x182644FA0")]
		public bool ProcMsg(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007A91 RID: 31377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A91")]
		[Address(RVA = "0x26458B0", Offset = "0x26444B0", VA = "0x1826458B0")]
		public void Update()
		{
		}

		// Token: 0x06007A92 RID: 31378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A92")]
		[Address(RVA = "0x2644C60", Offset = "0x2643860", VA = "0x182644C60")]
		public void OnDisconnect()
		{
		}

		// Token: 0x06007A93 RID: 31379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A93")]
		public void Register<TProtocol>(Action<TProtocol> handler) where TProtocol : Protocol, IRRPProtocol
		{
		}

		// Token: 0x06007A94 RID: 31380 RVA: 0x00036CF0 File Offset: 0x00034EF0
		[Token(Token = "0x6007A94")]
		[Address(RVA = "0x2645D90", Offset = "0x2644990", VA = "0x182645D90")]
		private int _GenRequestId()
		{
			return 0;
		}

		// Token: 0x06007A95 RID: 31381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007A95")]
		[Address(RVA = "0x2646080", Offset = "0x2644C80", VA = "0x182646080")]
		private NetMsg _Serialize(Protocol reqProtocol, int requestId)
		{
			return null;
		}

		// Token: 0x06007A96 RID: 31382 RVA: 0x00036D08 File Offset: 0x00034F08
		[Token(Token = "0x6007A96")]
		[Address(RVA = "0x2646000", Offset = "0x2644C00", VA = "0x182646000")]
		private int _ReadRequestId(NetMsg msg)
		{
			return 0;
		}

		// Token: 0x06007A97 RID: 31383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A97")]
		[Address(RVA = "0x2645C00", Offset = "0x2644800", VA = "0x182645C00")]
		private void _DoneRequest(RRPairMsgProcessor.RequestInfo reqInfo, RRPRespCode code, Protocol dnProtocol)
		{
		}

		// Token: 0x06007A98 RID: 31384 RVA: 0x00036D20 File Offset: 0x00034F20
		[Token(Token = "0x6007A98")]
		[Address(RVA = "0x2646310", Offset = "0x2644F10", VA = "0x182646310")]
		private bool _ShowMask(ServerLoadingMaskType maskKind)
		{
			return default(bool);
		}

		// Token: 0x06007A99 RID: 31385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A99")]
		[Address(RVA = "0x2645E00", Offset = "0x2644A00", VA = "0x182645E00")]
		private void _HideMask(ServerLoadingMaskType maskKind, Action callback)
		{
		}

		// Token: 0x0400788E RID: 30862
		[Token(Token = "0x400788E")]
		private const int TIME_OUT_SEC = 3;

		// Token: 0x0400788F RID: 30863
		[Token(Token = "0x400788F")]
		[FieldOffset(Offset = "0x10")]
		private readonly INetProtocolSuite m_protocolSuit;

		// Token: 0x04007890 RID: 30864
		[Token(Token = "0x4007890")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, RRPairMsgProcessor.RequestInfo> m_requestInfos;

		// Token: 0x04007891 RID: 30865
		[Token(Token = "0x4007891")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<uint, RRPairMsgProcessor.IHandler> m_innerHandles;

		// Token: 0x04007892 RID: 30866
		[Token(Token = "0x4007892")]
		[FieldOffset(Offset = "0x28")]
		private List<int> tempKeys;

		// Token: 0x04007893 RID: 30867
		[Token(Token = "0x4007893")]
		[FieldOffset(Offset = "0x30")]
		private List<RRPairMsgProcessor.RequestInfo> tempValues;

		// Token: 0x04007894 RID: 30868
		[Token(Token = "0x4007894")]
		[FieldOffset(Offset = "0x38")]
		private int m_nextRequestId;

		// Token: 0x04007897 RID: 30871
		[Token(Token = "0x4007897")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_logRule;

		// Token: 0x04007898 RID: 30872
		[Token(Token = "0x4007898")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_logRule;

		// Token: 0x04007899 RID: 30873
		[Token(Token = "0x4007899")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_mask;

		// Token: 0x0400789A RID: 30874
		[Token(Token = "0x400789A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_mask;

		// Token: 0x0400789B RID: 30875
		[Token(Token = "0x400789B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400789C RID: 30876
		[Token(Token = "0x400789C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TakeRequest;

		// Token: 0x0400789D RID: 30877
		[Token(Token = "0x400789D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ProcMsg;

		// Token: 0x0400789E RID: 30878
		[Token(Token = "0x400789E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_ProcMsg;

		// Token: 0x0400789F RID: 30879
		[Token(Token = "0x400789F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040078A0 RID: 30880
		[Token(Token = "0x40078A0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDisconnect;

		// Token: 0x040078A1 RID: 30881
		[Token(Token = "0x40078A1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Register;

		// Token: 0x040078A2 RID: 30882
		[Token(Token = "0x40078A2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GenRequestId;

		// Token: 0x040078A3 RID: 30883
		[Token(Token = "0x40078A3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__Serialize;

		// Token: 0x040078A4 RID: 30884
		[Token(Token = "0x40078A4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ReadRequestId;

		// Token: 0x040078A5 RID: 30885
		[Token(Token = "0x40078A5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DoneRequest;

		// Token: 0x040078A6 RID: 30886
		[Token(Token = "0x40078A6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ShowMask;

		// Token: 0x040078A7 RID: 30887
		[Token(Token = "0x40078A7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__HideMask;

		// Token: 0x020014C2 RID: 5314
		[Token(Token = "0x20014C2")]
		public abstract class RequestHandlerBase
		{
			// Token: 0x06007A9A RID: 31386
			[Token(Token = "0x6007A9A")]
			public abstract void ProcDnProtocol(RRPRespCode code, Protocol dnProtocol);

			// Token: 0x06007A9B RID: 31387
			[Token(Token = "0x6007A9B")]
			public abstract bool FillUpProtocol(Protocol upProtocol);

			// Token: 0x06007A9C RID: 31388
			[Token(Token = "0x6007A9C")]
			public abstract Protocol GetUpProtocol(INetProtocolSuite protoSuit);

			// Token: 0x06007A9D RID: 31389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A9D")]
			[Address(RVA = "0x2646870", Offset = "0x2645470", VA = "0x182646870")]
			protected RequestHandlerBase()
			{
			}

			// Token: 0x040078A8 RID: 30888
			[Token(Token = "0x40078A8")]
			[FieldOffset(Offset = "0x10")]
			public ServerLoadingMaskType maskType;
		}

		// Token: 0x020014C3 RID: 5315
		[Token(Token = "0x20014C3")]
		private class RequestInfo
		{
			// Token: 0x06007A9E RID: 31390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A9E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RequestInfo()
			{
			}

			// Token: 0x040078A9 RID: 30889
			[Token(Token = "0x40078A9")]
			[FieldOffset(Offset = "0x10")]
			public int requestId;

			// Token: 0x040078AA RID: 30890
			[Token(Token = "0x40078AA")]
			[FieldOffset(Offset = "0x14")]
			public float deadTime;

			// Token: 0x040078AB RID: 30891
			[Token(Token = "0x40078AB")]
			[FieldOffset(Offset = "0x18")]
			public RRPairMsgProcessor.RequestHandlerBase request;

			// Token: 0x040078AC RID: 30892
			[Token(Token = "0x40078AC")]
			[FieldOffset(Offset = "0x20")]
			public bool isShowingMask;
		}

		// Token: 0x020014C4 RID: 5316
		[Token(Token = "0x20014C4")]
		private interface IHandler
		{
			// Token: 0x06007A9F RID: 31391
			[Token(Token = "0x6007A9F")]
			bool ProcProtocol(Protocol protocol);
		}

		// Token: 0x020014C5 RID: 5317
		[Token(Token = "0x20014C5")]
		private class GenericHandler<TProtocol> : RRPairMsgProcessor.IHandler
		{
			// Token: 0x06007AA0 RID: 31392 RVA: 0x00036D38 File Offset: 0x00034F38
			[Token(Token = "0x6007AA0")]
			public bool ProcProtocol(Protocol protocol)
			{
				return default(bool);
			}

			// Token: 0x06007AA1 RID: 31393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AA1")]
			public GenericHandler()
			{
			}

			// Token: 0x040078AD RID: 30893
			[Token(Token = "0x40078AD")]
			[FieldOffset(Offset = "0x0")]
			public Action<TProtocol> onProcProtocol;
		}
	}
}
