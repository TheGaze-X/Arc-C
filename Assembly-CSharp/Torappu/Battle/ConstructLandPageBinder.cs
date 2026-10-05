using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.Scripts.UI.ConstructLand;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021B2 RID: 8626
	[Token(Token = "0x20021B2")]
	public class ConstructLandPageBinder : DataBinder<ConstructLandPageProp>
	{
		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x0600D75F RID: 55135 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D760 RID: 55136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001A2B")]
		public static ConstructLandPageBinder instance
		{
			[Token(Token = "0x600D75F")]
			[Address(RVA = "0x35CBC00", Offset = "0x35CA800", VA = "0x1835CBC00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600D760")]
			[Address(RVA = "0x35CBF40", Offset = "0x35CAB40", VA = "0x1835CBF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x0600D761 RID: 55137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A2C")]
		public PlayerSandboxV2 playerSandboxV2
		{
			[Token(Token = "0x600D761")]
			[Address(RVA = "0x35CBE00", Offset = "0x35CAA00", VA = "0x1835CBE00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x0600D762 RID: 55138 RVA: 0x0004DEC8 File Offset: 0x0004C0C8
		[Token(Token = "0x17001A2D")]
		public static bool isReady
		{
			[Token(Token = "0x600D762")]
			[Address(RVA = "0x35CBC50", Offset = "0x35CA850", VA = "0x1835CBC50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x0600D763 RID: 55139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A2E")]
		public EventPool<ConstructPageMsg.EventFromPage> eventPool
		{
			[Token(Token = "0x600D763")]
			[Address(RVA = "0x35CBBA0", Offset = "0x35CA7A0", VA = "0x1835CBBA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x0600D764 RID: 55140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A2F")]
		public ConstructLandPageModel model
		{
			[Token(Token = "0x600D764")]
			[Address(RVA = "0x35CBD70", Offset = "0x35CA970", VA = "0x1835CBD70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D765 RID: 55141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D765")]
		[Address(RVA = "0x35CAE20", Offset = "0x35C9A20", VA = "0x1835CAE20")]
		private void Awake()
		{
		}

		// Token: 0x0600D766 RID: 55142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D766")]
		[Address(RVA = "0x35CAFA0", Offset = "0x35C9BA0", VA = "0x1835CAFA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600D767 RID: 55143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D767")]
		[Address(RVA = "0x35CB040", Offset = "0x35C9C40", VA = "0x1835CB040")]
		public void OnGameReady(object arg)
		{
		}

		// Token: 0x0600D768 RID: 55144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D768")]
		[Address(RVA = "0x35CB5B0", Offset = "0x35CA1B0", VA = "0x1835CB5B0")]
		private void Update()
		{
		}

		// Token: 0x0600D769 RID: 55145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D769")]
		[Address(RVA = "0x35CAC60", Offset = "0x35C9860", VA = "0x1835CAC60")]
		public void AttachSceneBinder(ConstructLandPage page, ConstructLandPageProp prop, ConstructPageMsg pageMsg)
		{
		}

		// Token: 0x0600D76A RID: 55146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D76A")]
		[Address(RVA = "0x35CAD60", Offset = "0x35C9960", VA = "0x1835CAD60")]
		public void AttachSceneView(ConstructLandPageBinder.IConstructSceneView view)
		{
		}

		// Token: 0x0600D76B RID: 55147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D76B")]
		[Address(RVA = "0x35CAE90", Offset = "0x35C9A90", VA = "0x1835CAE90")]
		public void DetachSceneView(ConstructLandPageBinder.IConstructSceneView view)
		{
		}

		// Token: 0x0600D76C RID: 55148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D76C")]
		[Address(RVA = "0x35CB450", Offset = "0x35CA050", VA = "0x1835CB450")]
		public void UpdateConstructDetail()
		{
		}

		// Token: 0x0600D76D RID: 55149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D76D")]
		[Address(RVA = "0x35CB330", Offset = "0x35C9F30", VA = "0x1835CB330")]
		public void Trigger(ConstructPageMsg.EventFromScene signal)
		{
		}

		// Token: 0x0600D76E RID: 55150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D76E")]
		[Address(RVA = "0x35CAF20", Offset = "0x35C9B20", VA = "0x1835CAF20")]
		public void NotifyPage()
		{
		}

		// Token: 0x0600D76F RID: 55151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D76F")]
		[Address(RVA = "0x35CB120", Offset = "0x35C9D20", VA = "0x1835CB120", Slot = "7")]
		public override void OnValueChanged(ConstructLandPageProp property)
		{
		}

		// Token: 0x0600D770 RID: 55152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D770")]
		[Address(RVA = "0x35CB280", Offset = "0x35C9E80", VA = "0x1835CB280")]
		public void ShowSandboxTextToast(string msg)
		{
		}

		// Token: 0x0600D771 RID: 55153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D771")]
		[Address(RVA = "0x35CB800", Offset = "0x35CA400", VA = "0x1835CB800")]
		public ConstructLandPageBinder()
		{
		}

		// Token: 0x0400E7E0 RID: 59360
		[Token(Token = "0x400E7E0")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isReady;

		// Token: 0x0400E7E1 RID: 59361
		[Token(Token = "0x400E7E1")]
		[FieldOffset(Offset = "0x28")]
		private EventPool<ConstructPageMsg.EventFromPage> m_eventPool;

		// Token: 0x0400E7E2 RID: 59362
		[Token(Token = "0x400E7E2")]
		[FieldOffset(Offset = "0x30")]
		private ConstructPageMsg m_pageMsg;

		// Token: 0x0400E7E3 RID: 59363
		[Token(Token = "0x400E7E3")]
		[FieldOffset(Offset = "0x38")]
		private ConstructLandPage m_page;

		// Token: 0x0400E7E4 RID: 59364
		[Token(Token = "0x400E7E4")]
		[FieldOffset(Offset = "0x40")]
		private ConstructLandPageProp m_prop;

		// Token: 0x0400E7E5 RID: 59365
		[Token(Token = "0x400E7E5")]
		[FieldOffset(Offset = "0x48")]
		private ConstructLandPageModel m_fallbackModel;

		// Token: 0x0400E7E6 RID: 59366
		[Token(Token = "0x400E7E6")]
		[FieldOffset(Offset = "0x50")]
		private List<ConstructLandPageBinder.IConstructSceneView> m_views;

		// Token: 0x0400E7E7 RID: 59367
		[Token(Token = "0x400E7E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_instance;

		// Token: 0x0400E7E8 RID: 59368
		[Token(Token = "0x400E7E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_instance;

		// Token: 0x0400E7E9 RID: 59369
		[Token(Token = "0x400E7E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_playerSandboxV2;

		// Token: 0x0400E7EA RID: 59370
		[Token(Token = "0x400E7EA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isReady;

		// Token: 0x0400E7EB RID: 59371
		[Token(Token = "0x400E7EB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_eventPool;

		// Token: 0x0400E7EC RID: 59372
		[Token(Token = "0x400E7EC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_model;

		// Token: 0x0400E7ED RID: 59373
		[Token(Token = "0x400E7ED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400E7EE RID: 59374
		[Token(Token = "0x400E7EE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400E7EF RID: 59375
		[Token(Token = "0x400E7EF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x0400E7F0 RID: 59376
		[Token(Token = "0x400E7F0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400E7F1 RID: 59377
		[Token(Token = "0x400E7F1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_AttachSceneBinder;

		// Token: 0x0400E7F2 RID: 59378
		[Token(Token = "0x400E7F2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_AttachSceneView;

		// Token: 0x0400E7F3 RID: 59379
		[Token(Token = "0x400E7F3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DetachSceneView;

		// Token: 0x0400E7F4 RID: 59380
		[Token(Token = "0x400E7F4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UpdateConstructDetail;

		// Token: 0x0400E7F5 RID: 59381
		[Token(Token = "0x400E7F5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_Trigger;

		// Token: 0x0400E7F6 RID: 59382
		[Token(Token = "0x400E7F6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_NotifyPage;

		// Token: 0x0400E7F7 RID: 59383
		[Token(Token = "0x400E7F7")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400E7F8 RID: 59384
		[Token(Token = "0x400E7F8")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ShowSandboxTextToast;

		// Token: 0x0400E7F9 RID: 59385
		[Token(Token = "0x400E7F9")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020021B3 RID: 8627
		[Token(Token = "0x20021B3")]
		public interface IConstructSceneView
		{
			// Token: 0x0600D772 RID: 55154
			[Token(Token = "0x600D772")]
			void OnValueChanged(ConstructLandPageProp property);
		}
	}
}
