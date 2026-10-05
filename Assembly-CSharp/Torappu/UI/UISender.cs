using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Network;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200382D RID: 14381
	[Token(Token = "0x200382D")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class UISender
	{
		// Token: 0x06016CCE RID: 93390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016CCE")]
		public static UISender.ResultHandler<ResType> SendRequest<ResType>(Request request, [Optional] UISender.ResultHandler<ResType> wrappedHandler) where ResType : class
		{
			return null;
		}

		// Token: 0x06016CCF RID: 93391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016CCF")]
		public static UISender.ResultHandler<ResType> SendMultiFormRequest<ResType>(Request request, BinaryData[] binaryDatas, [Optional] UISender.ResultHandler<ResType> wrappedHandler) where ResType : class
		{
			return null;
		}

		// Token: 0x06016CD0 RID: 93392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016CD0")]
		[Address(RVA = "0xF4D230", Offset = "0xF4BE30", VA = "0x180F4D230")]
		public static UISender.MIMEResultHandler SendGet(string url, [Optional] string param)
		{
			return null;
		}

		// Token: 0x06016CD1 RID: 93393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016CD1")]
		[Address(RVA = "0xF4D110", Offset = "0xF4BD10", VA = "0x180F4D110")]
		public static void ResetNetwork()
		{
		}

		// Token: 0x06016CD2 RID: 93394 RVA: 0x00092FE8 File Offset: 0x000911E8
		[Token(Token = "0x6016CD2")]
		[Address(RVA = "0xF4CFE0", Offset = "0xF4BBE0", VA = "0x180F4CFE0")]
		public static bool IsBusy()
		{
			return default(bool);
		}

		// Token: 0x06016CD3 RID: 93395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016CD3")]
		private static UISender.ResultHandler<ResType> _SendRequest<ResType>(Request request, bool useMultiForm, BinaryData[] binaryDatas, UISender.ResultHandler<ResType> resultHandler) where ResType : class
		{
			return null;
		}

		// Token: 0x06016CD4 RID: 93396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016CD4")]
		private static void _HandleServiceResponse<ResType>(Request request, Response<ResType> response, UISender.ResultHandler<ResType> resultHandler)
		{
		}

		// Token: 0x06016CD5 RID: 93397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016CD5")]
		private static void _HandleFailedService<ResType>(Request request, Response<ResType> response, UISender.ResultHandler<ResType> handler)
		{
		}

		// Token: 0x06016CD6 RID: 93398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016CD6")]
		[Address(RVA = "0xF4D920", Offset = "0xF4C520", VA = "0x180F4D920")]
		private static UISender.MIMEResultHandler _SendHttpGet(string url, string param)
		{
			return null;
		}

		// Token: 0x06016CD7 RID: 93399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016CD7")]
		[Address(RVA = "0xF4D2B0", Offset = "0xF4BEB0", VA = "0x180F4D2B0")]
		private static void _HandleGetResponse(UISender.MIMEResultHandler handler, WebHttpResponse response)
		{
		}

		// Token: 0x06016CD8 RID: 93400 RVA: 0x00093000 File Offset: 0x00091200
		[Token(Token = "0x6016CD8")]
		[Address(RVA = "0xF4D590", Offset = "0xF4C190", VA = "0x180F4D590")]
		private static bool _ParseMIMEFromResponse(UISender.MIMEResultHandler handler, WebHttpResponse response, out UISender.MIMEObject mime)
		{
			return default(bool);
		}

		// Token: 0x06016CD9 RID: 93401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016CD9")]
		[Address(RVA = "0xF4D880", Offset = "0xF4C480", VA = "0x180F4D880")]
		private static void _ReloginCallback()
		{
		}

		// Token: 0x06016CDA RID: 93402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016CDA")]
		[Address(RVA = "0xF4D800", Offset = "0xF4C400", VA = "0x180F4D800")]
		private static UIFloatMask _PickLoadingMask(UISender.LoadMaskType maskType)
		{
			return null;
		}

		// Token: 0x0401B7E4 RID: 112612
		[Token(Token = "0x401B7E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x0401B7E5 RID: 112613
		[Token(Token = "0x401B7E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SendMultiFormRequest;

		// Token: 0x0401B7E6 RID: 112614
		[Token(Token = "0x401B7E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SendGet;

		// Token: 0x0401B7E7 RID: 112615
		[Token(Token = "0x401B7E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetNetwork;

		// Token: 0x0401B7E8 RID: 112616
		[Token(Token = "0x401B7E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsBusy;

		// Token: 0x0401B7E9 RID: 112617
		[Token(Token = "0x401B7E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendRequest;

		// Token: 0x0401B7EA RID: 112618
		[Token(Token = "0x401B7EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandleServiceResponse;

		// Token: 0x0401B7EB RID: 112619
		[Token(Token = "0x401B7EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__HandleFailedService;

		// Token: 0x0401B7EC RID: 112620
		[Token(Token = "0x401B7EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SendHttpGet;

		// Token: 0x0401B7ED RID: 112621
		[Token(Token = "0x401B7ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HandleGetResponse;

		// Token: 0x0401B7EE RID: 112622
		[Token(Token = "0x401B7EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ParseMIMEFromResponse;

		// Token: 0x0401B7EF RID: 112623
		[Token(Token = "0x401B7EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ReloginCallback;

		// Token: 0x0401B7F0 RID: 112624
		[Token(Token = "0x401B7F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__PickLoadingMask;

		// Token: 0x0200382E RID: 14382
		[Token(Token = "0x200382E")]
		private class SenderContext : Singleton<UISender.SenderContext>
		{
			// Token: 0x06016CDB RID: 93403 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016CDB")]
			[Address(RVA = "0xF3B200", Offset = "0xF39E00", VA = "0x180F3B200")]
			private SenderContext()
			{
			}

			// Token: 0x06016CDC RID: 93404 RVA: 0x00093018 File Offset: 0x00091218
			[Token(Token = "0x6016CDC")]
			[Address(RVA = "0xF3B150", Offset = "0xF39D50", VA = "0x180F3B150")]
			public bool HasBusyServices()
			{
				return default(bool);
			}

			// Token: 0x0401B7F1 RID: 112625
			[Token(Token = "0x401B7F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HashSet<object> preSendingObjs;

			// Token: 0x0401B7F2 RID: 112626
			[Token(Token = "0x401B7F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<string> sendingServices;

			// Token: 0x0401B7F3 RID: 112627
			[Token(Token = "0x401B7F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ListDict<string, Action> pendingServices;

			// Token: 0x0401B7F4 RID: 112628
			[Token(Token = "0x401B7F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401B7F5 RID: 112629
			[Token(Token = "0x401B7F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_HasBusyServices;
		}

		// Token: 0x0200382F RID: 14383
		[Token(Token = "0x200382F")]
		public enum LoadMaskType
		{
			// Token: 0x0401B7F7 RID: 112631
			[Token(Token = "0x401B7F7")]
			POP_FLOAT,
			// Token: 0x0401B7F8 RID: 112632
			[Token(Token = "0x401B7F8")]
			NONE,
			// Token: 0x0401B7F9 RID: 112633
			[Token(Token = "0x401B7F9")]
			INVISIBLE
		}

		// Token: 0x02003830 RID: 14384
		[Token(Token = "0x2003830")]
		[Flags]
		public enum MetaFlags : long
		{
			// Token: 0x0401B7FB RID: 112635
			[Token(Token = "0x401B7FB")]
			NONE = 0L,
			// Token: 0x0401B7FC RID: 112636
			[Token(Token = "0x401B7FC")]
			IGNORE_PUSH_MSG = 1L,
			// Token: 0x0401B7FD RID: 112637
			[Token(Token = "0x401B7FD")]
			CALL_ONFANIL_WHEN_CANCEL = 2L
		}

		// Token: 0x02003831 RID: 14385
		[Token(Token = "0x2003831")]
		[LuaCallCSharp(GenFlag.No)]
		public enum ConcurrentType
		{
			// Token: 0x0401B7FF RID: 112639
			[Token(Token = "0x401B7FF")]
			NONE,
			// Token: 0x0401B800 RID: 112640
			[Token(Token = "0x401B800")]
			ABORT,
			// Token: 0x0401B801 RID: 112641
			[Token(Token = "0x401B801")]
			ENQUEUE,
			// Token: 0x0401B802 RID: 112642
			[Token(Token = "0x401B802")]
			PARALLEL
		}

		// Token: 0x02003832 RID: 14386
		[Token(Token = "0x2003832")]
		public class ResultHandler<ResType> : CustomYieldInstruction
		{
			// Token: 0x1700368A RID: 13962
			// (get) Token: 0x06016CDD RID: 93405 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06016CDE RID: 93406 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700368A")]
			public virtual Action<ResType> onProceed
			{
				[Token(Token = "0x6016CDD")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6016CDE")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700368B RID: 13963
			// (get) Token: 0x06016CDF RID: 93407 RVA: 0x00093030 File Offset: 0x00091230
			[Token(Token = "0x1700368B")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6016CDF")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700368C RID: 13964
			// (get) Token: 0x06016CE0 RID: 93408 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06016CE1 RID: 93409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700368C")]
			public virtual Func<ResponseError, bool> onBlock
			{
				[Token(Token = "0x6016CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6016CE1")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700368D RID: 13965
			// (get) Token: 0x06016CE2 RID: 93410 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06016CE3 RID: 93411 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700368D")]
			public virtual Action onFinal
			{
				[Token(Token = "0x6016CE2")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6016CE3")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06016CE4 RID: 93412 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016CE4")]
			public virtual Action SystemCancelHandler()
			{
				return null;
			}

			// Token: 0x1700368E RID: 13966
			// (get) Token: 0x06016CE5 RID: 93413 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06016CE6 RID: 93414 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700368E")]
			public virtual Action<ResponseStatus> beforeServiceFinish
			{
				[Token(Token = "0x6016CE5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6016CE6")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06016CE7 RID: 93415 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016CE7")]
			public void TriggerFinal()
			{
			}

			// Token: 0x06016CE8 RID: 93416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016CE8")]
			public void MarkFinish()
			{
			}

			// Token: 0x06016CE9 RID: 93417 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016CE9")]
			public ResultHandler()
			{
			}

			// Token: 0x0401B803 RID: 112643
			[Token(Token = "0x401B803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool m_finishDispose;

			// Token: 0x0401B807 RID: 112647
			[Token(Token = "0x401B807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UISender.LoadMaskType loadMaskType;

			// Token: 0x0401B808 RID: 112648
			[Token(Token = "0x401B808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UISender.ConcurrentType concurrentType;

			// Token: 0x0401B80A RID: 112650
			[Token(Token = "0x401B80A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UISender.MetaFlags metaFlags;
		}

		// Token: 0x02003833 RID: 14387
		[Token(Token = "0x2003833")]
		public enum MIMECategory
		{
			// Token: 0x0401B80C RID: 112652
			[Token(Token = "0x401B80C")]
			TEXT,
			// Token: 0x0401B80D RID: 112653
			[Token(Token = "0x401B80D")]
			BINARY,
			// Token: 0x0401B80E RID: 112654
			[Token(Token = "0x401B80E")]
			JSON
		}

		// Token: 0x02003834 RID: 14388
		[Token(Token = "0x2003834")]
		public struct MIMEObject
		{
			// Token: 0x0401B80F RID: 112655
			[Token(Token = "0x401B80F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string text;

			// Token: 0x0401B810 RID: 112656
			[Token(Token = "0x401B810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public byte[] data;

			// Token: 0x0401B811 RID: 112657
			[Token(Token = "0x401B811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object json;
		}

		// Token: 0x02003835 RID: 14389
		[Token(Token = "0x2003835")]
		public class MIMEResultHandler : UISender.ResultHandler<UISender.MIMEObject>
		{
			// Token: 0x06016CEA RID: 93418 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016CEA")]
			[Address(RVA = "0xF3A450", Offset = "0xF39050", VA = "0x180F3A450")]
			public MIMEResultHandler()
			{
			}

			// Token: 0x0401B812 RID: 112658
			[Token(Token = "0x401B812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public UISender.MIMECategory category;

			// Token: 0x0401B813 RID: 112659
			[Token(Token = "0x401B813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Type jsonType;
		}
	}
}
