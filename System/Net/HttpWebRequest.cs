using System;
using System.ComponentModel;
using System.IO;
using System.Net.Cache;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace System.Net
{
	// Token: 0x0200031D RID: 797
	[Token(Token = "0x200031D")]
	[Serializable]
	public class HttpWebRequest : WebRequest, ISerializable
	{
		// Token: 0x06001608 RID: 5640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001608")]
		[Address(RVA = "0x5080280", Offset = "0x507EE80", VA = "0x185080280")]
		public HttpWebRequest(Uri uri)
		{
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x5080520", Offset = "0x507F120", VA = "0x185080520")]
		[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
		protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x507FBE0", Offset = "0x507E7E0", VA = "0x18507FBE0")]
		private void ResetAuthorization()
		{
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160B")]
		[Address(RVA = "0x507FF80", Offset = "0x507EB80", VA = "0x18507FF80")]
		private void SetSpecialHeaders(string HeaderName, string value)
		{
		}

		// Token: 0x170004B3 RID: 1203
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B3")]
		public string Accept
		{
			[Token(Token = "0x600160C")]
			[Address(RVA = "0x5080B80", Offset = "0x507F780", VA = "0x185080B80")]
			set
			{
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B4")]
		public Uri Address
		{
			[Token(Token = "0x600160D")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (set) Token: 0x0600160E RID: 5646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B5")]
		public virtual bool AllowAutoRedirect
		{
			[Token(Token = "0x600160E")]
			[Address(RVA = "0x20339F0", Offset = "0x20325F0", VA = "0x1820339F0", Slot = "32")]
			set
			{
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x0000A1D0 File Offset: 0x000083D0
		[Token(Token = "0x170004B6")]
		public virtual bool AllowWriteStreamBuffering
		{
			[Token(Token = "0x600160F")]
			[Address(RVA = "0x4FC8F80", Offset = "0x4FC7B80", VA = "0x184FC8F80", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x0000A1E8 File Offset: 0x000083E8
		[Token(Token = "0x170004B7")]
		public DecompressionMethods AutomaticDecompression
		{
			[Token(Token = "0x6001610")]
			[Address(RVA = "0x5080700", Offset = "0x507F300", VA = "0x185080700")]
			get
			{
				return DecompressionMethods.None;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x0000A200 File Offset: 0x00008400
		[Token(Token = "0x170004B8")]
		internal bool InternalAllowBuffering
		{
			[Token(Token = "0x6001611")]
			[Address(RVA = "0x50808F0", Offset = "0x507F4F0", VA = "0x1850808F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x0000A218 File Offset: 0x00008418
		[Token(Token = "0x170004B9")]
		private bool MethodWithBuffer
		{
			[Token(Token = "0x6001612")]
			[Address(RVA = "0x5080900", Offset = "0x507F500", VA = "0x185080900")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BA")]
		internal MobileTlsProvider TlsProvider
		{
			[Token(Token = "0x6001613")]
			[Address(RVA = "0x5080A80", Offset = "0x507F680", VA = "0x185080A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BB")]
		internal MonoTlsSettings TlsSettings
		{
			[Token(Token = "0x6001614")]
			[Address(RVA = "0x1692740", Offset = "0x1691340", VA = "0x181692740")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BC")]
		public X509CertificateCollection ClientCertificates
		{
			[Token(Token = "0x6001615")]
			[Address(RVA = "0x5080710", Offset = "0x507F310", VA = "0x185080710")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x0000A230 File Offset: 0x00008430
		// (set) Token: 0x06001617 RID: 5655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BD")]
		public override long ContentLength
		{
			[Token(Token = "0x6001616")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10", Slot = "13")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001617")]
			[Address(RVA = "0x5080C30", Offset = "0x507F830", VA = "0x185080C30", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x170004BE RID: 1214
		// (set) Token: 0x06001618 RID: 5656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BE")]
		internal long InternalContentLength
		{
			[Token(Token = "0x6001618")]
			[Address(RVA = "0x4A5BFE0", Offset = "0x4A5ABE0", VA = "0x184A5BFE0")]
			set
			{
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x0000A248 File Offset: 0x00008448
		// (set) Token: 0x0600161A RID: 5658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BF")]
		internal bool ThrowOnError
		{
			[Token(Token = "0x6001619")]
			[Address(RVA = "0x5080A60", Offset = "0x507F660", VA = "0x185080A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600161A")]
			[Address(RVA = "0x50811B0", Offset = "0x507FDB0", VA = "0x1850811B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (set) Token: 0x0600161B RID: 5659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C0")]
		public override string ContentType
		{
			[Token(Token = "0x600161B")]
			[Address(RVA = "0x5080D10", Offset = "0x507F910", VA = "0x185080D10", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600161D RID: 5661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C1")]
		public override ICredentials Credentials
		{
			[Token(Token = "0x600161C")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x600161D")]
			[Address(RVA = "0xEDF340", Offset = "0xEDDF40", VA = "0x180EDF340", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600161E RID: 5662 RVA: 0x0000A260 File Offset: 0x00008460
		[Token(Token = "0x170004C2")]
		[MonoTODO]
		public static int DefaultMaximumErrorResponseLength
		{
			[Token(Token = "0x600161E")]
			[Address(RVA = "0x5080790", Offset = "0x507F390", VA = "0x185080790")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C3")]
		public override WebHeaderCollection Headers
		{
			[Token(Token = "0x600161F")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C4")]
		public string Host
		{
			[Token(Token = "0x6001620")]
			[Address(RVA = "0x50807E0", Offset = "0x507F3E0", VA = "0x1850807E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x0000A278 File Offset: 0x00008478
		// (set) Token: 0x06001622 RID: 5666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C5")]
		public bool KeepAlive
		{
			[Token(Token = "0x6001621")]
			[Address(RVA = "0x9069B0", Offset = "0x9055B0", VA = "0x1809069B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001622")]
			[Address(RVA = "0x906A70", Offset = "0x905670", VA = "0x180906A70")]
			set
			{
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x0000A290 File Offset: 0x00008490
		[Token(Token = "0x170004C6")]
		public int ReadWriteTimeout
		{
			[Token(Token = "0x6001623")]
			[Address(RVA = "0x5080A10", Offset = "0x507F610", VA = "0x185080A10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001625 RID: 5669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C7")]
		public override string Method
		{
			[Token(Token = "0x6001624")]
			[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001625")]
			[Address(RVA = "0x5080D80", Offset = "0x507F980", VA = "0x185080D80", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C8")]
		public Version ProtocolVersion
		{
			[Token(Token = "0x6001626")]
			[Address(RVA = "0x20BBCF0", Offset = "0x20BA8F0", VA = "0x1820BBCF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001628 RID: 5672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C9")]
		public override IWebProxy Proxy
		{
			[Token(Token = "0x6001627")]
			[Address(RVA = "0x2569110", Offset = "0x2567D10", VA = "0x182569110", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001628")]
			[Address(RVA = "0x5081010", Offset = "0x507FC10", VA = "0x185081010", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170004CA RID: 1226
		// (set) Token: 0x06001629 RID: 5673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CA")]
		public string Referer
		{
			[Token(Token = "0x6001629")]
			[Address(RVA = "0x50810B0", Offset = "0x507FCB0", VA = "0x1850810B0")]
			set
			{
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CB")]
		public override Uri RequestUri
		{
			[Token(Token = "0x600162A")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x0000A2A8 File Offset: 0x000084A8
		[Token(Token = "0x170004CC")]
		public bool SendChunked
		{
			[Token(Token = "0x600162B")]
			[Address(RVA = "0x5080A20", Offset = "0x507F620", VA = "0x185080A20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CD")]
		public ServicePoint ServicePoint
		{
			[Token(Token = "0x600162C")]
			[Address(RVA = "0x5080A50", Offset = "0x507F650", VA = "0x185080A50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CE")]
		internal ServicePoint ServicePointNoLock
		{
			[Token(Token = "0x600162D")]
			[Address(RVA = "0x4D6C490", Offset = "0x4D6B090", VA = "0x184D6C490")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x0000A2C0 File Offset: 0x000084C0
		// (set) Token: 0x0600162F RID: 5679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CF")]
		public override int Timeout
		{
			[Token(Token = "0x600162E")]
			[Address(RVA = "0x5080A70", Offset = "0x507F670", VA = "0x185080A70", Slot = "21")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600162F")]
			[Address(RVA = "0x50811C0", Offset = "0x507FDC0", VA = "0x1850811C0", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D0")]
		public string TransferEncoding
		{
			[Token(Token = "0x6001630")]
			[Address(RVA = "0x5080A90", Offset = "0x507F690", VA = "0x185080A90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x0000A2D8 File Offset: 0x000084D8
		[Token(Token = "0x170004D1")]
		public override bool UseDefaultCredentials
		{
			[Token(Token = "0x6001631")]
			[Address(RVA = "0x5080AF0", Offset = "0x507F6F0", VA = "0x185080AF0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D2")]
		public string UserAgent
		{
			[Token(Token = "0x6001632")]
			[Address(RVA = "0x5081240", Offset = "0x507FE40", VA = "0x185081240")]
			set
			{
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x0000A2F0 File Offset: 0x000084F0
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D3")]
		public bool UnsafeAuthenticatedConnectionSharing
		{
			[Token(Token = "0x6001633")]
			[Address(RVA = "0x5080AE0", Offset = "0x507F6E0", VA = "0x185080AE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001634")]
			[Address(RVA = "0x5081230", Offset = "0x507FE30", VA = "0x185081230")]
			set
			{
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x0000A308 File Offset: 0x00008508
		// (set) Token: 0x06001636 RID: 5686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D4")]
		internal bool ExpectContinue
		{
			[Token(Token = "0x6001635")]
			[Address(RVA = "0xD742E0", Offset = "0xD72EE0", VA = "0x180D742E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001636")]
			[Address(RVA = "0x5080D60", Offset = "0x507F960", VA = "0x185080D60")]
			set
			{
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D5")]
		internal Uri AuthUri
		{
			[Token(Token = "0x6001637")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x0000A320 File Offset: 0x00008520
		[Token(Token = "0x170004D6")]
		internal bool ProxyQuery
		{
			[Token(Token = "0x6001638")]
			[Address(RVA = "0x50809E0", Offset = "0x507F5E0", VA = "0x1850809E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D7")]
		internal ServerCertValidationCallback ServerCertValidationCallback
		{
			[Token(Token = "0x6001639")]
			[Address(RVA = "0x4E84380", Offset = "0x4E82F80", VA = "0x184E84380")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D8")]
		public RemoteCertificateValidationCallback ServerCertificateValidationCallback
		{
			[Token(Token = "0x600163A")]
			[Address(RVA = "0x5080A30", Offset = "0x507F630", VA = "0x185080A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163B")]
		[Address(RVA = "0x507EAC0", Offset = "0x507D6C0", VA = "0x18507EAC0")]
		internal ServicePoint GetServicePoint()
		{
			return null;
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163C")]
		[Address(RVA = "0x507FCF0", Offset = "0x507E8F0", VA = "0x18507FCF0")]
		private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163D")]
		[Address(RVA = "0x507F150", Offset = "0x507DD50", VA = "0x18507F150")]
		private Task<Stream> MyGetRequestStreamAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x507CBF0", Offset = "0x507B7F0", VA = "0x18507CBF0", Slot = "27")]
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x507D750", Offset = "0x507C350", VA = "0x18507D750", Slot = "28")]
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			return null;
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x507E5F0", Offset = "0x507D1F0", VA = "0x18507E5F0", Slot = "23")]
		public override Stream GetRequestStream()
		{
			return null;
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001641")]
		[Address(RVA = "0x507E560", Offset = "0x507D160", VA = "0x18507E560", Slot = "29")]
		public override Task<Stream> GetRequestStreamAsync()
		{
			return null;
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001642")]
		internal static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort, Func<bool> aborted, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001643")]
		private static Task<T> RunWithTimeoutWorker<T>(Task<T> workerTask, int timeout, Action abort, Func<bool> aborted, CancellationTokenSource cts)
		{
			return null;
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001644")]
		private Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func)
		{
			return null;
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001645")]
		[Address(RVA = "0x507F550", Offset = "0x507E150", VA = "0x18507F550")]
		private Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x507E6A0", Offset = "0x507D2A0", VA = "0x18507E6A0")]
		private Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x507D910", Offset = "0x507C510", VA = "0x18507D910")]
		internal static Exception FlattenException(Exception e)
		{
			return null;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001648")]
		[Address(RVA = "0x507EEB0", Offset = "0x507DAB0", VA = "0x18507EEB0")]
		private WebException GetWebException(Exception e)
		{
			return null;
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001649")]
		[Address(RVA = "0x507EBD0", Offset = "0x507D7D0", VA = "0x18507EBD0")]
		private static WebException GetWebException(Exception e, bool aborted)
		{
			return null;
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164A")]
		[Address(RVA = "0x507D470", Offset = "0x507C070", VA = "0x18507D470")]
		internal static WebException CreateRequestAbortedException()
		{
			return null;
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164B")]
		[Address(RVA = "0x507CCB0", Offset = "0x507B8B0", VA = "0x18507CCB0", Slot = "25")]
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164C")]
		[Address(RVA = "0x507D830", Offset = "0x507C430", VA = "0x18507D830", Slot = "26")]
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			return null;
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164D")]
		[Address(RVA = "0x507E7F0", Offset = "0x507D3F0", VA = "0x18507E7F0", Slot = "24")]
		public override WebResponse GetResponse()
		{
			return null;
		}

		// Token: 0x170004D9 RID: 1241
		// (set) Token: 0x0600164E RID: 5710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D9")]
		internal bool FinishedReading
		{
			[Token(Token = "0x600164E")]
			[Address(RVA = "0x5080D70", Offset = "0x507F970", VA = "0x185080D70")]
			set
			{
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x0000A338 File Offset: 0x00008538
		[Token(Token = "0x170004DA")]
		internal bool Aborted
		{
			[Token(Token = "0x600164F")]
			[Address(RVA = "0x50806D0", Offset = "0x507F2D0", VA = "0x1850806D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x507CB00", Offset = "0x507B700", VA = "0x18507CB00", Slot = "31")]
		public override void Abort()
		{
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001651")]
		[Address(RVA = "0x5080030", Offset = "0x507EC30", VA = "0x185080030", Slot = "6")]
		private void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001652")]
		[Address(RVA = "0x507E0C0", Offset = "0x507CCC0", VA = "0x18507E0C0", Slot = "7")]
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001653")]
		[Address(RVA = "0x507D400", Offset = "0x507C000", VA = "0x18507D400")]
		private void CheckRequestStarted()
		{
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001654")]
		[Address(RVA = "0x507D520", Offset = "0x507C120", VA = "0x18507D520")]
		internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers)
		{
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001655")]
		[Address(RVA = "0x507FC70", Offset = "0x507E870", VA = "0x18507FC70")]
		private void RewriteRedirectToGet()
		{
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0000A350 File Offset: 0x00008550
		[Token(Token = "0x6001656")]
		[Address(RVA = "0x507F660", Offset = "0x507E260", VA = "0x18507F660")]
		private bool Redirect(HttpStatusCode code, WebResponse response)
		{
			return default(bool);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001657")]
		[Address(RVA = "0x507D9F0", Offset = "0x507C5F0", VA = "0x18507D9F0")]
		private string GetHeaders()
		{
			return null;
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001658")]
		[Address(RVA = "0x507D540", Offset = "0x507C140", VA = "0x18507D540")]
		private void DoPreAuthenticate()
		{
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001659")]
		[Address(RVA = "0x507E110", Offset = "0x507CD10", VA = "0x18507E110")]
		internal byte[] GetRequestHeaders()
		{
			return null;
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x0000A368 File Offset: 0x00008568
		[Token(Token = "0x600165A")]
		[Address(RVA = "0x507EF30", Offset = "0x507DB30", VA = "0x18507EF30")]
		private ValueTuple<WebOperation, bool> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			return default(ValueTuple<WebOperation, bool>);
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0000A380 File Offset: 0x00008580
		[Token(Token = "0x600165B")]
		[Address(RVA = "0x507CE90", Offset = "0x507BA90", VA = "0x18507CE90")]
		private bool CheckAuthorization(WebResponse response, HttpStatusCode code)
		{
			return default(bool);
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0000A398 File Offset: 0x00008598
		[Token(Token = "0x600165C")]
		[Address(RVA = "0x507E8A0", Offset = "0x507D4A0", VA = "0x18507E8A0")]
		private ValueTuple<Task<BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect)
		{
			return default(ValueTuple<Task<BufferOffsetSize>, WebException>);
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0000A3B0 File Offset: 0x000085B0
		[Token(Token = "0x600165D")]
		[Address(RVA = "0x507CEC0", Offset = "0x507BAC0", VA = "0x18507CEC0")]
		private ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response)
		{
			return default(ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>);
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001660")]
		[Address(RVA = "0x5080250", Offset = "0x507EE50", VA = "0x185080250")]
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public HttpWebRequest()
		{
		}

		// Token: 0x04000C34 RID: 3124
		[Token(Token = "0x4000C34")]
		[FieldOffset(Offset = "0x38")]
		private Uri requestUri;

		// Token: 0x04000C35 RID: 3125
		[Token(Token = "0x4000C35")]
		[FieldOffset(Offset = "0x40")]
		private Uri actualUri;

		// Token: 0x04000C36 RID: 3126
		[Token(Token = "0x4000C36")]
		[FieldOffset(Offset = "0x48")]
		private bool hostChanged;

		// Token: 0x04000C37 RID: 3127
		[Token(Token = "0x4000C37")]
		[FieldOffset(Offset = "0x49")]
		private bool allowAutoRedirect;

		// Token: 0x04000C38 RID: 3128
		[Token(Token = "0x4000C38")]
		[FieldOffset(Offset = "0x4A")]
		private bool allowBuffering;

		// Token: 0x04000C39 RID: 3129
		[Token(Token = "0x4000C39")]
		[FieldOffset(Offset = "0x50")]
		private X509CertificateCollection certificates;

		// Token: 0x04000C3A RID: 3130
		[Token(Token = "0x4000C3A")]
		[FieldOffset(Offset = "0x58")]
		private string connectionGroup;

		// Token: 0x04000C3B RID: 3131
		[Token(Token = "0x4000C3B")]
		[FieldOffset(Offset = "0x60")]
		private bool haveContentLength;

		// Token: 0x04000C3C RID: 3132
		[Token(Token = "0x4000C3C")]
		[FieldOffset(Offset = "0x68")]
		private long contentLength;

		// Token: 0x04000C3D RID: 3133
		[Token(Token = "0x4000C3D")]
		[FieldOffset(Offset = "0x70")]
		private HttpContinueDelegate continueDelegate;

		// Token: 0x04000C3E RID: 3134
		[Token(Token = "0x4000C3E")]
		[FieldOffset(Offset = "0x78")]
		private CookieContainer cookieContainer;

		// Token: 0x04000C3F RID: 3135
		[Token(Token = "0x4000C3F")]
		[FieldOffset(Offset = "0x80")]
		private ICredentials credentials;

		// Token: 0x04000C40 RID: 3136
		[Token(Token = "0x4000C40")]
		[FieldOffset(Offset = "0x88")]
		private bool haveResponse;

		// Token: 0x04000C41 RID: 3137
		[Token(Token = "0x4000C41")]
		[FieldOffset(Offset = "0x89")]
		private bool requestSent;

		// Token: 0x04000C42 RID: 3138
		[Token(Token = "0x4000C42")]
		[FieldOffset(Offset = "0x90")]
		private WebHeaderCollection webHeaders;

		// Token: 0x04000C43 RID: 3139
		[Token(Token = "0x4000C43")]
		[FieldOffset(Offset = "0x98")]
		private bool keepAlive;

		// Token: 0x04000C44 RID: 3140
		[Token(Token = "0x4000C44")]
		[FieldOffset(Offset = "0x9C")]
		private int maxAutoRedirect;

		// Token: 0x04000C45 RID: 3141
		[Token(Token = "0x4000C45")]
		[FieldOffset(Offset = "0xA0")]
		private string mediaType;

		// Token: 0x04000C46 RID: 3142
		[Token(Token = "0x4000C46")]
		[FieldOffset(Offset = "0xA8")]
		private string method;

		// Token: 0x04000C47 RID: 3143
		[Token(Token = "0x4000C47")]
		[FieldOffset(Offset = "0xB0")]
		private string initialMethod;

		// Token: 0x04000C48 RID: 3144
		[Token(Token = "0x4000C48")]
		[FieldOffset(Offset = "0xB8")]
		private bool pipelined;

		// Token: 0x04000C49 RID: 3145
		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0xB9")]
		private bool preAuthenticate;

		// Token: 0x04000C4A RID: 3146
		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0xBA")]
		private bool usedPreAuth;

		// Token: 0x04000C4B RID: 3147
		[Token(Token = "0x4000C4B")]
		[FieldOffset(Offset = "0xC0")]
		private Version version;

		// Token: 0x04000C4C RID: 3148
		[Token(Token = "0x4000C4C")]
		[FieldOffset(Offset = "0xC8")]
		private bool force_version;

		// Token: 0x04000C4D RID: 3149
		[Token(Token = "0x4000C4D")]
		[FieldOffset(Offset = "0xD0")]
		private Version actualVersion;

		// Token: 0x04000C4E RID: 3150
		[Token(Token = "0x4000C4E")]
		[FieldOffset(Offset = "0xD8")]
		private IWebProxy proxy;

		// Token: 0x04000C4F RID: 3151
		[Token(Token = "0x4000C4F")]
		[FieldOffset(Offset = "0xE0")]
		private bool sendChunked;

		// Token: 0x04000C50 RID: 3152
		[Token(Token = "0x4000C50")]
		[FieldOffset(Offset = "0xE8")]
		private ServicePoint servicePoint;

		// Token: 0x04000C51 RID: 3153
		[Token(Token = "0x4000C51")]
		[FieldOffset(Offset = "0xF0")]
		private int timeout;

		// Token: 0x04000C52 RID: 3154
		[Token(Token = "0x4000C52")]
		[FieldOffset(Offset = "0xF4")]
		private int continueTimeout;

		// Token: 0x04000C53 RID: 3155
		[Token(Token = "0x4000C53")]
		[FieldOffset(Offset = "0xF8")]
		private WebRequestStream writeStream;

		// Token: 0x04000C54 RID: 3156
		[Token(Token = "0x4000C54")]
		[FieldOffset(Offset = "0x100")]
		private HttpWebResponse webResponse;

		// Token: 0x04000C55 RID: 3157
		[Token(Token = "0x4000C55")]
		[FieldOffset(Offset = "0x108")]
		private WebCompletionSource responseTask;

		// Token: 0x04000C56 RID: 3158
		[Token(Token = "0x4000C56")]
		[FieldOffset(Offset = "0x110")]
		private WebOperation currentOperation;

		// Token: 0x04000C57 RID: 3159
		[Token(Token = "0x4000C57")]
		[FieldOffset(Offset = "0x118")]
		private int aborted;

		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		[FieldOffset(Offset = "0x11C")]
		private bool gotRequestStream;

		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		[FieldOffset(Offset = "0x120")]
		private int redirects;

		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		[FieldOffset(Offset = "0x124")]
		private bool expectContinue;

		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		[FieldOffset(Offset = "0x125")]
		private bool getResponseCalled;

		// Token: 0x04000C5C RID: 3164
		[Token(Token = "0x4000C5C")]
		[FieldOffset(Offset = "0x128")]
		private object locker;

		// Token: 0x04000C5D RID: 3165
		[Token(Token = "0x4000C5D")]
		[FieldOffset(Offset = "0x130")]
		private bool finished_reading;

		// Token: 0x04000C5E RID: 3166
		[Token(Token = "0x4000C5E")]
		[FieldOffset(Offset = "0x134")]
		private DecompressionMethods auto_decomp;

		// Token: 0x04000C5F RID: 3167
		[Token(Token = "0x4000C5F")]
		[FieldOffset(Offset = "0x0")]
		private static int defaultMaxResponseHeadersLength;

		// Token: 0x04000C60 RID: 3168
		[Token(Token = "0x4000C60")]
		[FieldOffset(Offset = "0x4")]
		private static int defaultMaximumErrorResponseLength;

		// Token: 0x04000C61 RID: 3169
		[Token(Token = "0x4000C61")]
		[FieldOffset(Offset = "0x8")]
		private static RequestCachePolicy defaultCachePolicy;

		// Token: 0x04000C62 RID: 3170
		[Token(Token = "0x4000C62")]
		[FieldOffset(Offset = "0x138")]
		private int readWriteTimeout;

		// Token: 0x04000C63 RID: 3171
		[Token(Token = "0x4000C63")]
		[FieldOffset(Offset = "0x140")]
		private MobileTlsProvider tlsProvider;

		// Token: 0x04000C64 RID: 3172
		[Token(Token = "0x4000C64")]
		[FieldOffset(Offset = "0x148")]
		private MonoTlsSettings tlsSettings;

		// Token: 0x04000C65 RID: 3173
		[Token(Token = "0x4000C65")]
		[FieldOffset(Offset = "0x150")]
		private ServerCertValidationCallback certValidationCallback;

		// Token: 0x04000C66 RID: 3174
		[Token(Token = "0x4000C66")]
		[FieldOffset(Offset = "0x158")]
		private bool hostHasPort;

		// Token: 0x04000C67 RID: 3175
		[Token(Token = "0x4000C67")]
		[FieldOffset(Offset = "0x160")]
		private Uri hostUri;

		// Token: 0x04000C68 RID: 3176
		[Token(Token = "0x4000C68")]
		[FieldOffset(Offset = "0x168")]
		private HttpWebRequest.AuthorizationState auth_state;

		// Token: 0x04000C69 RID: 3177
		[Token(Token = "0x4000C69")]
		[FieldOffset(Offset = "0x178")]
		private HttpWebRequest.AuthorizationState proxy_auth_state;

		// Token: 0x04000C6A RID: 3178
		[Token(Token = "0x4000C6A")]
		[FieldOffset(Offset = "0x188")]
		[NonSerialized]
		internal Func<Stream, Task> ResendContentFactory;

		// Token: 0x04000C6C RID: 3180
		[Token(Token = "0x4000C6C")]
		[FieldOffset(Offset = "0x191")]
		private bool unsafe_auth_blah;

		// Token: 0x0200031E RID: 798
		[Token(Token = "0x200031E")]
		private enum NtlmAuthState
		{
			// Token: 0x04000C6E RID: 3182
			[Token(Token = "0x4000C6E")]
			None,
			// Token: 0x04000C6F RID: 3183
			[Token(Token = "0x4000C6F")]
			Challenge,
			// Token: 0x04000C70 RID: 3184
			[Token(Token = "0x4000C70")]
			Response
		}

		// Token: 0x0200031F RID: 799
		[Token(Token = "0x200031F")]
		private struct AuthorizationState
		{
			// Token: 0x170004DB RID: 1243
			// (get) Token: 0x06001661 RID: 5729 RVA: 0x0000A3E0 File Offset: 0x000085E0
			[Token(Token = "0x170004DB")]
			public bool IsCompleted
			{
				[Token(Token = "0x6001661")]
				[Address(RVA = "0x4C084E0", Offset = "0x4C070E0", VA = "0x184C084E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170004DC RID: 1244
			// (get) Token: 0x06001662 RID: 5730 RVA: 0x0000A3F8 File Offset: 0x000085F8
			[Token(Token = "0x170004DC")]
			public HttpWebRequest.NtlmAuthState NtlmAuthState
			{
				[Token(Token = "0x6001662")]
				[Address(RVA = "0x319ED80", Offset = "0x319D980", VA = "0x18319ED80")]
				get
				{
					return HttpWebRequest.NtlmAuthState.None;
				}
			}

			// Token: 0x170004DD RID: 1245
			// (get) Token: 0x06001663 RID: 5731 RVA: 0x0000A410 File Offset: 0x00008610
			[Token(Token = "0x170004DD")]
			public bool IsNtlmAuthenticated
			{
				[Token(Token = "0x6001663")]
				[Address(RVA = "0x5068EE0", Offset = "0x5067AE0", VA = "0x185068EE0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06001664 RID: 5732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001664")]
			[Address(RVA = "0x5068EA0", Offset = "0x5067AA0", VA = "0x185068EA0")]
			public AuthorizationState(HttpWebRequest request, bool isProxy)
			{
			}

			// Token: 0x06001665 RID: 5733 RVA: 0x0000A428 File Offset: 0x00008628
			[Token(Token = "0x6001665")]
			[Address(RVA = "0x5068950", Offset = "0x5067550", VA = "0x185068950")]
			public bool CheckAuthorization(WebResponse response, HttpStatusCode code)
			{
				return default(bool);
			}

			// Token: 0x06001666 RID: 5734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001666")]
			[Address(RVA = "0x5068D40", Offset = "0x5067940", VA = "0x185068D40")]
			public void Reset()
			{
			}

			// Token: 0x06001667 RID: 5735 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001667")]
			[Address(RVA = "0x5068DC0", Offset = "0x50679C0", VA = "0x185068DC0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000C71 RID: 3185
			[Token(Token = "0x4000C71")]
			[FieldOffset(Offset = "0x0")]
			private readonly HttpWebRequest request;

			// Token: 0x04000C72 RID: 3186
			[Token(Token = "0x4000C72")]
			[FieldOffset(Offset = "0x8")]
			private readonly bool isProxy;

			// Token: 0x04000C73 RID: 3187
			[Token(Token = "0x4000C73")]
			[FieldOffset(Offset = "0x9")]
			private bool isCompleted;

			// Token: 0x04000C74 RID: 3188
			[Token(Token = "0x4000C74")]
			[FieldOffset(Offset = "0xC")]
			private HttpWebRequest.NtlmAuthState ntlm_auth_state;
		}
	}
}
