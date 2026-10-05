using System;
using System.Collections;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YoStar.SDK.LitJson;
using YoStar.SDK.UIWidgets;

namespace YoStar.SDK.UI
{
	// Token: 0x0200018A RID: 394
	[Token(Token = "0x200018A")]
	public class NetStatusIndicatorPanel : BasePanel
	{
		// Token: 0x060009B3 RID: 2483 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x5C70370", Offset = "0x5C6EF70", VA = "0x185C70370", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x5C6F6C0", Offset = "0x5C6E2C0", VA = "0x185C6F6C0")]
		private JsonData CreateData(string internetUrl, string gameUrl, string sdkHost, string wifiIpv4)
		{
			return null;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x5C6FAC0", Offset = "0x5C6E6C0", VA = "0x185C6FAC0")]
		private JsonData CreateItemData(string pingType, string title, string type, int delayTime, string hostName)
		{
			return null;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Update()
		{
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x5C716D0", Offset = "0x5C702D0", VA = "0x185C716D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x5C71C10", Offset = "0x5C70810", VA = "0x185C71C10")]
		private void Start()
		{
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x5C6F460", Offset = "0x5C6E060", VA = "0x185C6F460")]
		public void CopyReportId()
		{
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x5C71940", Offset = "0x5C70540", VA = "0x185C71940")]
		public void StartNetCheck()
		{
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x5C6F400", Offset = "0x5C6E000", VA = "0x185C6F400")]
		public void ContactCustomerService()
		{
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x5C71220", Offset = "0x5C6FE20", VA = "0x185C71220")]
		public void NetCheckPanelClose()
		{
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x5C6F3A0", Offset = "0x5C6DFA0", VA = "0x185C6F3A0")]
		private IEnumerator Close()
		{
			return null;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x5C71380", Offset = "0x5C6FF80", VA = "0x185C71380")]
		private void NewPingHostDelayTime()
		{
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x5C6F300", Offset = "0x5C6DF00", VA = "0x185C6F300")]
		public void CancelTasks()
		{
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x5C712A0", Offset = "0x5C6FEA0", VA = "0x185C712A0")]
		private void NetworkViewReloadData()
		{
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x5C6FBE0", Offset = "0x5C6E7E0", VA = "0x185C6FBE0")]
		private Task CreateNetworkDelayTask(JsonData dataSource, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x5C6F5B0", Offset = "0x5C6E1B0", VA = "0x185C6F5B0")]
		private Task CreateAliNetworkDelayTask(JsonData dataSource, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x5C71AB0", Offset = "0x5C706B0", VA = "0x185C71AB0")]
		private Task<JsonData> StartNetworkDetection(string hostName, string traceID, string context, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000035CC File Offset: 0x000017CC
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x5C70240", Offset = "0x5C6EE40", VA = "0x185C70240")]
		private static NetworkReachability GetNetworkReachabilityType()
		{
			return NetworkReachability.NotReachable;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x5C6FE00", Offset = "0x5C6EA00", VA = "0x185C6FE00")]
		private Task GetArpEntriesCountAsync(JsonData dataSource, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x5C6FCF0", Offset = "0x5C6E8F0", VA = "0x185C6FCF0")]
		private Task GetAliDeviceNum(JsonData dataSource, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x5C71830", Offset = "0x5C70430", VA = "0x185C71830")]
		private Task PingGatewayAsync(JsonData dataSource, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x5C6FF10", Offset = "0x5C6EB10", VA = "0x185C6FF10")]
		private string GetDefaultGateway()
		{
			return null;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x5C71700", Offset = "0x5C70300", VA = "0x185C71700")]
		private Task<PingReply> PingDomainAsync(string domain, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x5C71D50", Offset = "0x5C70950", VA = "0x185C71D50")]
		private void UpdateHostDelay(double delay, string type)
		{
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x5C72470", Offset = "0x5C71070", VA = "0x185C72470")]
		private void UpdateLanScannerCount(int count, string type)
		{
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x5C6F320", Offset = "0x5C6DF20", VA = "0x185C6F320")]
		private IEnumerator CheckNetworkStatus()
		{
			return null;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000035E4 File Offset: 0x000017E4
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x5C70250", Offset = "0x5C6EE50", VA = "0x185C70250")]
		private NetworkType GetNetworkType()
		{
			return NetworkType.WiFi;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000035FC File Offset: 0x000017FC
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x5C71160", Offset = "0x5C6FD60", VA = "0x185C71160")]
		private bool IsWiredNetwork(NetworkInterface ni)
		{
			return default(bool);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00003614 File Offset: 0x00001814
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x5C71110", Offset = "0x5C6FD10", VA = "0x185C71110")]
		private bool IsWiFiNetwork(NetworkInterface ni)
		{
			return default(bool);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public NetStatusIndicatorPanel()
		{
		}

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0x50")]
		private NetStatusIndicator netStatusView;

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		[FieldOffset(Offset = "0x58")]
		private GameObject reportIDGroup;

		// Token: 0x04000637 RID: 1591
		[Token(Token = "0x4000637")]
		[FieldOffset(Offset = "0x60")]
		private Text reportId;

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		[FieldOffset(Offset = "0x68")]
		private bool netChecking;

		// Token: 0x04000639 RID: 1593
		[Token(Token = "0x4000639")]
		[FieldOffset(Offset = "0x6C")]
		private NetworkType networkType;

		// Token: 0x0400063A RID: 1594
		[Token(Token = "0x400063A")]
		[FieldOffset(Offset = "0x70")]
		private JsonData netInfoDataSource;

		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x400063B")]
		[FieldOffset(Offset = "0x78")]
		private string internetUrl;

		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		[FieldOffset(Offset = "0x80")]
		private string gameUrl;

		// Token: 0x0400063D RID: 1597
		[Token(Token = "0x400063D")]
		[FieldOffset(Offset = "0x88")]
		private string sdkHost;

		// Token: 0x0400063E RID: 1598
		[Token(Token = "0x400063E")]
		[FieldOffset(Offset = "0x90")]
		private string wifiIpv4;

		// Token: 0x0400063F RID: 1599
		[Token(Token = "0x400063F")]
		[FieldOffset(Offset = "0x98")]
		private CancellationTokenSource cancellationTokenSource;

		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		[FieldOffset(Offset = "0xA0")]
		private SynchronizationContext mainThreadContext;
	}
}
