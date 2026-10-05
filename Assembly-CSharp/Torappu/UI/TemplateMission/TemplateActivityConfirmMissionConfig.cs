using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D80 RID: 15744
	[Token(Token = "0x2003D80")]
	public class TemplateActivityConfirmMissionConfig<TResponse> : TemplateMissionConfirmServiceConfig<TemplateActivityConfirmMissionRequest, TResponse> where TResponse : TemplateMissionCommonConfirmResponse
	{
		// Token: 0x17003A76 RID: 14966
		// (get) Token: 0x060187E6 RID: 100326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A76")]
		protected override string serviceCode
		{
			[Token(Token = "0x60187E6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060187E7 RID: 100327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187E7")]
		public TemplateActivityConfirmMissionConfig(List<string> missionIdList)
		{
		}

		// Token: 0x060187E8 RID: 100328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60187E8")]
		protected override TemplateActivityConfirmMissionRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x0401E02E RID: 122926
		[Token(Token = "0x401E02E")]
		[FieldOffset(Offset = "0x0")]
		private List<string> m_missionIdList;

		// Token: 0x0401E02F RID: 122927
		[Token(Token = "0x401E02F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0401E030 RID: 122928
		[Token(Token = "0x401E030")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401E031 RID: 122929
		[Token(Token = "0x401E031")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
