using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051F2 RID: 20978
	[Token(Token = "0x20051F2")]
	public class RoguelikeDicePage : UIPage
	{
		// Token: 0x0601EF8C RID: 126860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF8C")]
		public static void Open<PluginType>(string topicId) where PluginType : RoguelikeDicePlugin
		{
		}

		// Token: 0x0601EF8D RID: 126861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF8D")]
		[Address(RVA = "0x18B1AA0", Offset = "0x18B06A0", VA = "0x1818B1AA0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601EF8E RID: 126862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF8E")]
		[Address(RVA = "0x18B1E20", Offset = "0x18B0A20", VA = "0x1818B1E20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601EF8F RID: 126863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF8F")]
		[Address(RVA = "0x18B1BA0", Offset = "0x18B07A0", VA = "0x1818B1BA0")]
		private void _EventOnComplete()
		{
		}

		// Token: 0x0601EF90 RID: 126864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF90")]
		[Address(RVA = "0x18B1CE0", Offset = "0x18B08E0", VA = "0x1818B1CE0")]
		private void _EventOnReroll()
		{
		}

		// Token: 0x0601EF91 RID: 126865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF91")]
		[Address(RVA = "0x18B2540", Offset = "0x18B1140", VA = "0x1818B2540")]
		private void _ReqChoice(RoguelikeDiceChoiceRequest.Choice aChoice, Action callback)
		{
		}

		// Token: 0x0601EF92 RID: 126866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF92")]
		[Address(RVA = "0x18B27C0", Offset = "0x18B13C0", VA = "0x1818B27C0")]
		public RoguelikeDicePage()
		{
		}

		// Token: 0x0601EF95 RID: 126869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF95")]
		[Address(RVA = "0xE98770", Offset = "0xE97370", VA = "0x180E98770")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x040298F9 RID: 170233
		[Token(Token = "0x40298F9")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Transform _viewRoot;

		// Token: 0x040298FA RID: 170234
		[Token(Token = "0x40298FA")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Transform _pluginRoot;

		// Token: 0x040298FB RID: 170235
		[Token(Token = "0x40298FB")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Transform _diceSceneRoot;

		// Token: 0x040298FC RID: 170236
		[Token(Token = "0x40298FC")]
		[FieldOffset(Offset = "0xF0")]
		private RoguelikeDiceView m_view;

		// Token: 0x040298FD RID: 170237
		[Token(Token = "0x40298FD")]
		[FieldOffset(Offset = "0xF8")]
		private RoguelikeDicePlugin m_plugin;

		// Token: 0x040298FE RID: 170238
		[Token(Token = "0x40298FE")]
		[FieldOffset(Offset = "0x100")]
		private RoguelikeDiceModelProperty m_prop;

		// Token: 0x040298FF RID: 170239
		[Token(Token = "0x40298FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Open;

		// Token: 0x04029900 RID: 170240
		[Token(Token = "0x4029900")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04029901 RID: 170241
		[Token(Token = "0x4029901")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029902 RID: 170242
		[Token(Token = "0x4029902")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnComplete;

		// Token: 0x04029903 RID: 170243
		[Token(Token = "0x4029903")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnReroll;

		// Token: 0x04029904 RID: 170244
		[Token(Token = "0x4029904")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ReqChoice;

		// Token: 0x04029905 RID: 170245
		[Token(Token = "0x4029905")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020051F3 RID: 20979
		[Token(Token = "0x20051F3")]
		public class Params
		{
			// Token: 0x0601EF96 RID: 126870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EF96")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04029906 RID: 170246
			[Token(Token = "0x4029906")]
			[FieldOffset(Offset = "0x10")]
			public string topic;

			// Token: 0x04029907 RID: 170247
			[Token(Token = "0x4029907")]
			[FieldOffset(Offset = "0x18")]
			public Type typeOfPlugin;
		}
	}
}
