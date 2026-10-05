using System;
using Il2CppDummyDll;
using Torappu.Setting;
using UnityEngine;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FFC RID: 16380
	[Token(Token = "0x2003FFC")]
	public abstract class SettingCommonObject : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003C81 RID: 15489
		// (set) Token: 0x060195DE RID: 103902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C81")]
		public SettingConstVars.SettingType settingType
		{
			[Token(Token = "0x60195DE")]
			[Address(RVA = "0x1224A00", Offset = "0x1223600", VA = "0x181224A00")]
			set
			{
			}
		}

		// Token: 0x060195DF RID: 103903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195DF")]
		[Address(RVA = "0x1224640", Offset = "0x1223240", VA = "0x181224640", Slot = "4")]
		protected virtual void RefreshState()
		{
		}

		// Token: 0x060195E0 RID: 103904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195E0")]
		[Address(RVA = "0x12244B0", Offset = "0x12230B0", VA = "0x1812244B0")]
		protected void OnEnable()
		{
		}

		// Token: 0x060195E1 RID: 103905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195E1")]
		[Address(RVA = "0x1224340", Offset = "0x1222F40", VA = "0x181224340")]
		private void OnDestroy()
		{
		}

		// Token: 0x060195E2 RID: 103906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195E2")]
		[Address(RVA = "0x12248B0", Offset = "0x12234B0", VA = "0x1812248B0", Slot = "5")]
		protected virtual void SetData(SettingConstVars.SettingType type = SettingConstVars.SettingType.ALL)
		{
		}

		// Token: 0x060195E3 RID: 103907
		[Token(Token = "0x60195E3")]
		protected abstract void SetCommonObjectEnabled(bool enabled);

		// Token: 0x060195E4 RID: 103908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195E4")]
		[Address(RVA = "0x1224990", Offset = "0x1223590", VA = "0x181224990")]
		protected SettingCommonObject()
		{
		}

		// Token: 0x0401F8E9 RID: 129257
		[Token(Token = "0x401F8E9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected SettingConstVars.DataType _dataType;

		// Token: 0x0401F8EA RID: 129258
		[Token(Token = "0x401F8EA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected SettingConstVars.SettingType _settingType;

		// Token: 0x0401F8EB RID: 129259
		[Token(Token = "0x401F8EB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected SettingConstVars.InstantFlag _instantFlag;

		// Token: 0x0401F8EC RID: 129260
		[Token(Token = "0x401F8EC")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected SettingConstVars.SettingType _parentType;

		// Token: 0x0401F8ED RID: 129261
		[Token(Token = "0x401F8ED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected SettingCommonObjectPlugin _plugin;

		// Token: 0x0401F8EE RID: 129262
		[Token(Token = "0x401F8EE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected SettingPlatform _platform;

		// Token: 0x0401F8EF RID: 129263
		[Token(Token = "0x401F8EF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected GameObject _holder;

		// Token: 0x0401F8F0 RID: 129264
		[Token(Token = "0x401F8F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_settingType;

		// Token: 0x0401F8F1 RID: 129265
		[Token(Token = "0x401F8F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshState;

		// Token: 0x0401F8F2 RID: 129266
		[Token(Token = "0x401F8F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401F8F3 RID: 129267
		[Token(Token = "0x401F8F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401F8F4 RID: 129268
		[Token(Token = "0x401F8F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401F8F5 RID: 129269
		[Token(Token = "0x401F8F5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FFD RID: 16381
		[Token(Token = "0x2003FFD")]
		public class SettingCommomObjectPluginHandler
		{
			// Token: 0x060195E5 RID: 103909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60195E5")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public SettingCommomObjectPluginHandler(SettingCommonObject closure)
			{
			}

			// Token: 0x060195E6 RID: 103910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60195E6")]
			[Address(RVA = "0x1223FF0", Offset = "0x1222BF0", VA = "0x181223FF0")]
			public void SetCommonObjectEnabled(bool enabled)
			{
			}

			// Token: 0x0401F8F6 RID: 129270
			[Token(Token = "0x401F8F6")]
			[FieldOffset(Offset = "0x10")]
			private SettingCommonObject _closure;
		}
	}
}
