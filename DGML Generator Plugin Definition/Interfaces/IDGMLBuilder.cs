/*ISC License

Copyright (c) 2018, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator.Plugin.Definition
{
    ///TODO add description <summary></summary>
    public interface IDGMLBuilder
    {
        ///TODO add description <summary></summary>
        /// <param name="Nodes"></param>
        void Add(params Node[] Nodes);

        ///TODO add description <summary></summary>
        /// <param name="Nodes"></param>
        void Add(List<Node> Nodes);

        ///TODO add description <summary></summary>
        /// <param name="Links"></param>
        void Add(params Link[] Links);

        ///TODO add description <summary></summary>
        /// <param name="Nodes"></param>
        void Add(List<Link> Nodes);

        ///TODO add description <summary></summary>
        Node GetNode(string ID);

        ///TODO add description <summary></summary>
        /// <param name="N"></param>
        void SetNode(Node N);
        
        ///TODO add description <summary></summary>
        Link GetLink(string ID);

        ///TODO add description <summary></summary>
        /// <param name="N"></param>
        void SetLink(Link L);
    }
}
