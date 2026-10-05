using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;

namespace Torappu.Building.UI
{
	// Token: 0x02001B77 RID: 7031
	[Token(Token = "0x2001B77")]
	public class BuildingPagePluginController : UIPageController.PluginController
	{
		// Token: 0x0600B02D RID: 45101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B02D")]
		[Address(RVA = "0x32A4CC0", Offset = "0x32A38C0", VA = "0x1832A4CC0", Slot = "4")]
		protected override void AddPlugin(UIPage page, Action<UIPage, UIPage.Plugin> pluginSetter)
		{
		}

		// Token: 0x0600B02E RID: 45102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B02E")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public BuildingPagePluginController()
		{
		}

		// Token: 0x02001B78 RID: 7032
		[Token(Token = "0x2001B78")]
		public class Plugin : StateEnginePage.Plugin
		{
			// Token: 0x0600B02F RID: 45103 RVA: 0x00043650 File Offset: 0x00041850
			[Token(Token = "0x600B02F")]
			[Address(RVA = "0x32B08B0", Offset = "0x32AF4B0", VA = "0x1832B08B0", Slot = "5")]
			public override bool OverrideCreate(Action<DataBundle> onCreate, DataBundle savedInst)
			{
				return default(bool);
			}

			// Token: 0x0600B030 RID: 45104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B030")]
			[Address(RVA = "0x32B0720", Offset = "0x32AF320", VA = "0x1832B0720", Slot = "11")]
			public override void OnDestroy()
			{
			}

			// Token: 0x0600B031 RID: 45105 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B031")]
			[Address(RVA = "0x32B0B20", Offset = "0x32AF720", VA = "0x1832B0B20", Slot = "12")]
			public override IEnumerator OverrideEffectsOnShow(Func<bool, IEnumerator> effectsOnShow, bool isFromStack)
			{
				return null;
			}

			// Token: 0x0600B032 RID: 45106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B032")]
			[Address(RVA = "0x32B0BC0", Offset = "0x32AF7C0", VA = "0x1832B0BC0")]
			public Plugin()
			{
			}

			// Token: 0x0400AA7A RID: 43642
			[Token(Token = "0x400AA7A")]
			[FieldOffset(Offset = "0x18")]
			private ListDict<BuildingEvent, EventPool.EventCallbackDelegate> m_bindedEvents;
		}
	}
}
