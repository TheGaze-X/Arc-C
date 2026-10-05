using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Lua
{
	// Token: 0x02001601 RID: 5633
	[Token(Token = "0x2001601")]
	public class LuaUIComponent : MonoBehaviour, IContextHost
	{
		// Token: 0x06007FD4 RID: 32724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FD4")]
		[Address(RVA = "0x2890830", Offset = "0x288F430", VA = "0x182890830")]
		private ILoadAsset _SelectAssetLoader()
		{
			return null;
		}

		// Token: 0x06007FD5 RID: 32725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FD5")]
		[Address(RVA = "0x2890700", Offset = "0x288F300", VA = "0x182890700")]
		private UnityEngine.Object _SelectCompDialogHost()
		{
			return null;
		}

		// Token: 0x06007FD6 RID: 32726 RVA: 0x00038238 File Offset: 0x00036438
		[Token(Token = "0x6007FD6")]
		[Address(RVA = "0x28908A0", Offset = "0x288F4A0", VA = "0x1828908A0")]
		private bool _TestIfCoreCompReady()
		{
			return default(bool);
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06007FD7 RID: 32727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F22")]
		public Transform root
		{
			[Token(Token = "0x6007FD7")]
			[Address(RVA = "0x2890A30", Offset = "0x288F630", VA = "0x182890A30", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06007FD8 RID: 32728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F23")]
		public string mainDialog
		{
			[Token(Token = "0x6007FD8")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007FD9 RID: 32729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FD9")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public IDictionary<string, Type> CompDeclaration()
		{
			return null;
		}

		// Token: 0x06007FDA RID: 32730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FDA")]
		public T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06007FDB RID: 32731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FDB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public void OnLeaveContext()
		{
		}

		// Token: 0x06007FDC RID: 32732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FDC")]
		[Address(RVA = "0x2890750", Offset = "0x288F350", VA = "0x182890750", Slot = "5")]
		public void UnloadAsset(UnityEngine.Object asset)
		{
		}

		// Token: 0x06007FDD RID: 32733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FDD")]
		[Address(RVA = "0x2890700", Offset = "0x288F300", VA = "0x182890700", Slot = "10")]
		public UnityEngine.Object UICompDialogHost()
		{
			return null;
		}

		// Token: 0x06007FDE RID: 32734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FDE")]
		[Address(RVA = "0x2890510", Offset = "0x288F110", VA = "0x182890510")]
		private void Start()
		{
		}

		// Token: 0x06007FDF RID: 32735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FDF")]
		[Address(RVA = "0x2890460", Offset = "0x288F060", VA = "0x182890460")]
		private void OnDestroy()
		{
		}

		// Token: 0x06007FE0 RID: 32736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FE0")]
		[Address(RVA = "0x2890930", Offset = "0x288F530", VA = "0x182890930")]
		private IEnumerator _WaitForCoreCompReady(Action nextStep)
		{
			return null;
		}

		// Token: 0x06007FE1 RID: 32737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FE1")]
		[Address(RVA = "0x2890810", Offset = "0x288F410", VA = "0x182890810")]
		private void _InitComponent()
		{
		}

		// Token: 0x06007FE2 RID: 32738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FE2")]
		[Address(RVA = "0x28909C0", Offset = "0x288F5C0", VA = "0x1828909C0")]
		public LuaUIComponent()
		{
		}

		// Token: 0x04008149 RID: 33097
		[Token(Token = "0x4008149")]
		private const int INIT_WAIT_FRAMES = 10;

		// Token: 0x0400814A RID: 33098
		[Token(Token = "0x400814A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _root;

		// Token: 0x0400814B RID: 33099
		[Token(Token = "0x400814B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _dialogClass;

		// Token: 0x0400814C RID: 33100
		[Token(Token = "0x400814C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ControllerDefine[] _ctrlDefines;

		// Token: 0x0400814D RID: 33101
		[Token(Token = "0x400814D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ValueFieldDefine[] _valueDefines;

		// Token: 0x0400814E RID: 33102
		[Token(Token = "0x400814E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LuaUIComponent.UICoreCompHost _hostType;

		// Token: 0x0400814F RID: 33103
		[Token(Token = "0x400814F")]
		[FieldOffset(Offset = "0x40")]
		private LuaUIContext m_luaContext;

		// Token: 0x04008150 RID: 33104
		[Token(Token = "0x4008150")]
		[FieldOffset(Offset = "0x48")]
		private IEnumerator m_initRoutine;

		// Token: 0x04008151 RID: 33105
		[Token(Token = "0x4008151")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFiner;

		// Token: 0x04008152 RID: 33106
		[Token(Token = "0x4008152")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04008153 RID: 33107
		[Token(Token = "0x4008153")]
		[FieldOffset(Offset = "0x70")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x02001602 RID: 5634
		[Token(Token = "0x2001602")]
		private enum UICoreCompHost
		{
			// Token: 0x04008155 RID: 33109
			[Token(Token = "0x4008155")]
			PAGE,
			// Token: 0x04008156 RID: 33110
			[Token(Token = "0x4008156")]
			STATE,
			// Token: 0x04008157 RID: 33111
			[Token(Token = "0x4008157")]
			COMP_DIALOG
		}
	}
}
