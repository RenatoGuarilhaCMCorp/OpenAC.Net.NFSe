﻿// ***********************************************************************
// Assembly         : OpenAC.Net.NFSe
// Author           : Rafael Dias
// Created          : 09-12-2024
//
// Last Modified By : Rafael Dias
// Last Modified On : 09-12-2024
// ***********************************************************************
// <copyright path="EventoRpsCollection.cs" company="OpenAC .Net">
//		        		   The MIT License (MIT)
//	     		Copyright (c) 2014 - 2024 Projeto OpenAC .Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using OpenAC.Net.DFe.Core.Collection;

namespace OpenAC.Net.NFSe.Nota;

public sealed class EventoRpsCollection : DFeCollection<EventoRps>
{
    #region Constructor

    /// <summary>
    /// Inicializa uma nova instacia da classe <see cref="NotaServicoCollection" />.
    /// </summary>
    /// <param name="config">The configuration.</param>
    public EventoRpsCollection()
    {
    }

    #endregion Constructor

    #region Methods

    /// <summary>
    /// Adiciona uma nova nota fiscal na coleção.
    /// </summary>
    /// <returns>T.</returns>
    public override EventoRps AddNew()
    {
        var evento = new EventoRps();
        Add(evento);
        return evento;
    }
    #endregion Methods
}