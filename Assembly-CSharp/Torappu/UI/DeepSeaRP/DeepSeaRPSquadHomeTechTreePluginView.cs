using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005179 RID: 20857
	[Token(Token = "0x2005179")]
	public class DeepSeaRPSquadHomeTechTreePluginView : SquadHomePluginView
	{
		// Token: 0x0601ED1D RID: 126237 RVA: 0x000AFDE8 File Offset: 0x000ADFE8
		[Token(Token = "0x601ED1D")]
		[Address(RVA = "0x1872720", Offset = "0x1871320", VA = "0x181872720", Slot = "10")]
		public override bool ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x0601ED1E RID: 126238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED1E")]
		[Address(RVA = "0x1872780", Offset = "0x1871380", VA = "0x181872780", Slot = "8")]
		public override void Show(SquadHomePlugin.PluginInputParams param)
		{
		}

		// Token: 0x0601ED1F RID: 126239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED1F")]
		[Address(RVA = "0x1873810", Offset = "0x1872410", VA = "0x181873810")]
		private void _TryTriggerAVG(List<DeepSeaRPSquadHomeTechTreePluginView.TechInfo> techInfos)
		{
		}

		// Token: 0x0601ED20 RID: 126240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED20")]
		[Address(RVA = "0x18725C0", Offset = "0x18711C0", VA = "0x1818725C0")]
		public void EventOnEditTechTreeBtnClick()
		{
		}

		// Token: 0x0601ED21 RID: 126241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ED21")]
		[Address(RVA = "0x1872C50", Offset = "0x1871850", VA = "0x181872C50")]
		private string _GetRetroGroupIdByStageId(string stageId)
		{
			return null;
		}

		// Token: 0x0601ED22 RID: 126242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ED22")]
		[Address(RVA = "0x1872D30", Offset = "0x1871930", VA = "0x181872D30")]
		private List<DeepSeaRPSquadHomeTechTreePluginView.TechInfo> _RefreshTechInfoList(SquadHomePlugin.PluginInputParams param)
		{
			return null;
		}

		// Token: 0x0601ED23 RID: 126243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ED23")]
		[Address(RVA = "0x18736F0", Offset = "0x18722F0", VA = "0x1818736F0")]
		private PlayerDeepSea.TechData _TryGetPlayerData(string techId)
		{
			return null;
		}

		// Token: 0x0601ED24 RID: 126244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED24")]
		[Address(RVA = "0x1873970", Offset = "0x1872570", VA = "0x181873970")]
		public DeepSeaRPSquadHomeTechTreePluginView()
		{
		}

		// Token: 0x0601ED25 RID: 126245 RVA: 0x000AFE00 File Offset: 0x000AE000
		[Token(Token = "0x601ED25")]
		[Address(RVA = "0x1872C40", Offset = "0x1871840", VA = "0x181872C40")]
		private bool <>xLuaBaseProxy_ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x04029553 RID: 169299
		[Token(Token = "0x4029553")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<DeepSeaRPSquadHomeTechTreePluginItemView> _techItems;

		// Token: 0x04029554 RID: 169300
		[Token(Token = "0x4029554")]
		[FieldOffset(Offset = "0x38")]
		private bool m_canEdit;

		// Token: 0x04029555 RID: 169301
		[Token(Token = "0x4029555")]
		[FieldOffset(Offset = "0x39")]
		private bool m_isRetro;

		// Token: 0x04029556 RID: 169302
		[Token(Token = "0x4029556")]
		[FieldOffset(Offset = "0x40")]
		private string m_groupId;

		// Token: 0x04029557 RID: 169303
		[Token(Token = "0x4029557")]
		[FieldOffset(Offset = "0x48")]
		private string m_stageId;

		// Token: 0x04029558 RID: 169304
		[Token(Token = "0x4029558")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, PlayerDeepSea.TechData> m_dicTechPlayerData;

		// Token: 0x04029559 RID: 169305
		[Token(Token = "0x4029559")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowSquadLeftArrow;

		// Token: 0x0402955A RID: 169306
		[Token(Token = "0x402955A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0402955B RID: 169307
		[Token(Token = "0x402955B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryTriggerAVG;

		// Token: 0x0402955C RID: 169308
		[Token(Token = "0x402955C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnEditTechTreeBtnClick;

		// Token: 0x0402955D RID: 169309
		[Token(Token = "0x402955D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetRetroGroupIdByStageId;

		// Token: 0x0402955E RID: 169310
		[Token(Token = "0x402955E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshTechInfoList;

		// Token: 0x0402955F RID: 169311
		[Token(Token = "0x402955F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryGetPlayerData;

		// Token: 0x04029560 RID: 169312
		[Token(Token = "0x4029560")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200517A RID: 20858
		[Token(Token = "0x200517A")]
		public class TechInfo
		{
			// Token: 0x0601ED26 RID: 126246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ED26")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TechInfo()
			{
			}

			// Token: 0x04029561 RID: 169313
			[Token(Token = "0x4029561")]
			[FieldOffset(Offset = "0x10")]
			public string techId;

			// Token: 0x04029562 RID: 169314
			[Token(Token = "0x4029562")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04029563 RID: 169315
			[Token(Token = "0x4029563")]
			[FieldOffset(Offset = "0x20")]
			public string defaultBranchId;

			// Token: 0x04029564 RID: 169316
			[Token(Token = "0x4029564")]
			[FieldOffset(Offset = "0x28")]
			public PlayerDeepSea.TechData playerData;

			// Token: 0x04029565 RID: 169317
			[Token(Token = "0x4029565")]
			[FieldOffset(Offset = "0x30")]
			public string selectBranchId;
		}
	}
}
